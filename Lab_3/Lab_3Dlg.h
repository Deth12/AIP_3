
// Lab_3Dlg.h: файл заголовка
//

#pragma once


// Диалоговое окно CLab3Dlg
class CLab3Dlg : public CDialogEx
{
// Создание
public:
	CLab3Dlg(CWnd* pParent = nullptr);	// стандартный конструктор

// Данные диалогового окна
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_LAB_3_DIALOG };
#endif

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// поддержка DDX/DDV


// Реализация
protected:
	HICON m_hIcon;
	// Созданные функции схемы сообщений
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
//	afx_msg void OnEnChangeEdit1();
	CEdit inputBox1;
	CEdit inputBox2;
	CButton button1;
	afx_msg void OnBnClickedButton1();
	afx_msg void OnBnClickedButton2();
};
