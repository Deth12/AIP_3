
// MFCACCESSDlg.cpp: файл реализации
//

#include "pch.h"
#include "framework.h"
#include "MFCACCESS.h"
#include "MFCACCESSDlg.h"
#include "afxdialogex.h"
#include "DBControl.h"
#include "AddDlg.h"


#ifdef _DEBUG
#define new DEBUG_NEW
#endif

class CAboutDlg : public CDialogEx
{
public:
	CAboutDlg();

// Данные диалогового окна
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_ABOUTBOX };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV

// Реализация
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialogEx(IDD_ABOUTBOX)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialogEx)
END_MESSAGE_MAP()


CMFCACCESSDlg::CMFCACCESSDlg(CWnd* pParent /*=nullptr*/)
	: CDialog(IDD_MFCACCESS_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CMFCACCESSDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_LIST1, teachersList);
	DDX_Control(pDX, IDC_LIST2, subjectsList);
	DDX_Control(pDX, IDC_ADD_BUTTON, addButton);
	DDX_Control(pDX, IDC_DELETE_BUTTON, deleteButton);
}

BEGIN_MESSAGE_MAP(CMFCACCESSDlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_NOTIFY(NM_CLICK, IDC_LIST1, &CMFCACCESSDlg::OnNMClickList1)
	ON_BN_CLICKED(IDC_ADD_BUTTON, &CMFCACCESSDlg::OnBnClickedAddButton)
	ON_BN_CLICKED(IDC_DELETE_BUTTON, &CMFCACCESSDlg::OnBnClickedDeleteButton)
	ON_BN_CLICKED(IDC_REFRESH_BUTTON, &CMFCACCESSDlg::OnBnClickedRefreshButton)
END_MESSAGE_MAP()

DBControl db;
BOOL CMFCACCESSDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Добавление пункта "О программе..." в системное меню.

	// IDM_ABOUTBOX должен быть в пределах системной команды.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != nullptr)
	{
		BOOL bNameValid;
		CString strAboutMenu;
		bNameValid = strAboutMenu.LoadString(IDS_ABOUTBOX);
		ASSERT(bNameValid);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Задает значок для этого диалогового окна.  Среда делает это автоматически,
	//  если главное окно приложения не является диалоговым
	SetIcon(m_hIcon, TRUE);			// Крупный значок
	SetIcon(m_hIcon, FALSE);		// Мелкий значок

	if (!EstablishDBConnection())
	{
		PostQuitMessage(0);
	}
	else
	{
		InsertTablesColumns();
		FillTeachersTable();
	}
	return TRUE;  // возврат значения TRUE, если фокус не передан элементу управления
}

void CMFCACCESSDlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

void CMFCACCESSDlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // контекст устройства для рисования

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Выравнивание значка по центру клиентского прямоугольника
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Нарисуйте значок
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

HCURSOR CMFCACCESSDlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

bool CMFCACCESSDlg::EstablishDBConnection()
{
	if (!db.OpenConnection())
	{
		AfxMessageBox(L"Ошибка открытия БД", MB_ICONSTOP);
		return false;
	}
	return true;
}

void CMFCACCESSDlg::InsertTablesColumns()
{
	subjectsList.InsertColumn(0, L"Предметы", 1, 240, 0);
	teachersList.InsertColumn(0, L"Отчество", 1, 125, 0);
	teachersList.InsertColumn(0, L"Имя", 1, 120, 0);
	teachersList.InsertColumn(0, L"Фамилия", 1, 125, 0);
	teachersList.InsertColumn(0, L"ID", 1, 50, 0);
}

void CMFCACCESSDlg::FillTeachersTable()
{
	CString teachersQuery = L"SELECT * FROM Teachers";
	recordSet = db.GetRecordset(teachersQuery);
	teachersList.DeleteAllItems();
	CString buffer;
	// определяем количество столбцов
	CHeaderCtrl* pHeader = (CHeaderCtrl*)teachersList.GetDlgItem(0);
	int colCount = pHeader->GetItemCount();
	for (int i = 0; i < (recordSet->GetRecordCount()) && !recordSet->IsEOF(); i++)
	{
		for (int n = 0; n < colCount; n++)
		{
			recordSet->GetFieldValue(n, buffer);
			if (n == 0)
			{
				teachersList.InsertItem(i, buffer);
			}
			else
			{
				teachersList.SetItemText(i, n, buffer);
			}
		}
		recordSet->MoveNext();
	}
	recordSet->Close();
}

void CMFCACCESSDlg::FillSubjectsTable(CString tID)
{
	CString subjectsQuery = L"SELECT (sName) FROM Subjects WHERE tID="+tID+"";
	recordSet = db.GetRecordset(subjectsQuery);
	subjectsList.DeleteAllItems();
	CString buffer;
	for (int i = 0; i < (recordSet->GetRecordCount()) && !recordSet->IsEOF(); i++)
	{
		recordSet->GetFieldValue((short)0, buffer);
		subjectsList.InsertItem(i, buffer);
		recordSet->MoveNext();
	}
}


void CMFCACCESSDlg::OnNMClickList1(NMHDR* pNMHDR, LRESULT* pResult)
{
	LPNMITEMACTIVATE pNMItemActivate = reinterpret_cast<LPNMITEMACTIVATE>(pNMHDR);
	*pResult = 0;

	CString tID;
	POSITION pos = teachersList.GetFirstSelectedItemPosition();
	if (pos == NULL)
	{
		return;
	}
	else
	{
		while (pos)
		{
			int nItem = teachersList.GetNextSelectedItem(pos);
			tID = teachersList.GetItemText(nItem, 0);
		}
	}
	FillSubjectsTable(tID);
}


void CMFCACCESSDlg::OnBnClickedAddButton()
{
	AddDlg a;
	a.DoModal();
}

void CMFCACCESSDlg::OnBnClickedDeleteButton()
{
	CString deleteID;
	POSITION pos = teachersList.GetFirstSelectedItemPosition();
	if (pos == NULL)
	{
		return;
	}
	else
	{
		while (pos)
		{
			int nItem = teachersList.GetNextSelectedItem(pos);
			deleteID = teachersList.GetItemText(nItem, 0);
		}
	}
	CString deleteQuery = L"DELETE FROM Teachers WHERE tID="+deleteID+"";
	CString updateSubjectsQuery = L"UPDATE Subjects SET tID=NULL WHERE tID="+deleteID+"";
	db.ExecuteQuery(updateSubjectsQuery);
	db.ExecuteQuery(deleteQuery);
	FillTeachersTable();
}


void CMFCACCESSDlg::OnBnClickedRefreshButton()
{
	CString teachersQuery = L"SELECT * FROM Teachers";
	FillTeachersTable();
}


