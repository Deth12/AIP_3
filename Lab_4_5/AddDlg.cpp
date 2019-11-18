// AddDlg.cpp: файл реализации
//

#include "pch.h"
#include "MFCACCESS.h"
#include "AddDlg.h"
#include "afxdialogex.h"
#include "afxdb.h"
#include "DBControl.h"

// Диалоговое окно AddDlg

IMPLEMENT_DYNAMIC(AddDlg, CDialogEx)

AddDlg::AddDlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_DIALOG1, pParent)
{

}

AddDlg::~AddDlg()
{
}

void AddDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_EDIT1, surnameBox);
	DDX_Control(pDX, IDC_EDIT2, nameBox);
	DDX_Control(pDX, IDC_EDIT3, fnameBox);
	DDX_Control(pDX, IDC_LIST1, subjectsList);
	DDX_Control(pDX, IDC_LIST2, selectedSubjects);
}


BEGIN_MESSAGE_MAP(AddDlg, CDialogEx)
	ON_BN_CLICKED(IDC_ADD_SUBJECT_BUTTON, &AddDlg::OnBnClickedAddSubjectButton)
	ON_BN_CLICKED(IDC_CONFIRM_BUTTON, &AddDlg::OnBnClickedConfirmButton)
	ON_WM_DESTROY()
END_MESSAGE_MAP()

DBControl dB;

BOOL AddDlg::OnInitDialog()
{
	CDialog::OnInitDialog();
	if (!EstablishConnection())
	{
		CDialog::EndDialog(0);
	}
	else
	{
		FillSubjectsTable();
		InsertColumns();
	}
	return TRUE;  // возврат значения TRUE, если фокус не передан элементу управления
}

bool AddDlg::EstablishConnection()
{
	if (!dB.OpenConnection())
	{
		AfxMessageBox(L"Ошибка открытия БД", MB_ICONSTOP);
		return false;
	}
	return true;
}

void AddDlg::InsertColumns()
{
	subjectsList.InsertColumn(0, L"Предметы", 1, 170, 0);
	selectedSubjects.InsertColumn(0, L"Предметы", 1, 170, 0);
}

void AddDlg::FillSubjectsTable()
{
	CString subjectsQuery = L"SELECT (sName) FROM Subjects WHERE tID IS NULL";
	recordSet = dB.GetRecordset(subjectsQuery);
	subjectsList.DeleteAllItems();
	CString buffer;
	for (int i = 0; i < (recordSet->GetRecordCount()) && !recordSet->IsEOF(); i++)
	{		
		recordSet->GetFieldValue((short)0, buffer);
		subjectsList.InsertItem(i, buffer);
		recordSet->MoveNext();
	}
}

void AddDlg::OnBnClickedAddSubjectButton()
{
	CString strText;
	POSITION pos = subjectsList.GetFirstSelectedItemPosition();
	if (pos == NULL)
	{
		return;
	}
	else
	{
		while (pos)
		{
			int nItem = subjectsList.GetNextSelectedItem(pos);
			strText = subjectsList.GetItemText(nItem, 0);
			subjectsList.DeleteItem(nItem);
		}
		selectedSubjects.InsertItem(0, strText);
	}
}

void AddDlg::OnBnClickedConfirmButton()
{
	CString surname;
	CString name;
	CString fname;
	surnameBox.GetWindowText(surname);
	nameBox.GetWindowText(name);
	fnameBox.GetWindowText(fname);
	CString tQuery = L"INSERT INTO Teachers (tSurname, tName, tFname) VALUES ('"+surname+"','"+name+"','"+fname+"')";
	dB.ExecuteQuery(tQuery);
	// Получаем ID только что добавленного преподавателя
	CString lastID;
	dB.GetRecordset(L"SELECT LAST(tID) FROM Teachers")->GetFieldValue((short)0, lastID);
	// Обновляем данные о предметах
	for (int i = 0; i < selectedSubjects.GetItemCount(); i++)
	{
		CString sName = selectedSubjects.GetItemText(i, 0);
		CString sQuery = L"UPDATE Subjects SET tID="+lastID+" WHERE sName='"+sName+"'";
		dB.ExecuteQuery(sQuery);
	}
	AfxMessageBox(L"Добавлено. Не забудьте обновить таблицы", MB_ICONASTERISK);
	dB.CloseConnection();
	CDialog::EndDialog(0);
}



void AddDlg::OnDestroy()
{
	CDialogEx::OnDestroy();
	dB.CloseConnection();
	// TODO: добавьте свой код обработчика сообщений
}
