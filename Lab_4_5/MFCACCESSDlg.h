
// MFCACCESSDlg.h: файл заголовка
//
#include <afxdb.h>
#include "DBControl.h"
#pragma once


// Диалоговое окно CMFCACCESSDlg
class CMFCACCESSDlg : public CDialog
{
// Создание
public:
	CMFCACCESSDlg(CWnd* pParent = nullptr);	// стандартный конструктор
private:
	bool EstablishDBConnection();
	void InsertTablesColumns();
	void FillTeachersTable();
	void FillSubjectsTable(CString);
// Данные диалогового окна
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_MFCACCESS_DIALOG };
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
	CRecordset* recordSet;
	CListCtrl teachersList;
	CListBox tList;
	CListCtrl subjectsList;
	afx_msg void OnNMClickList1(NMHDR* pNMHDR, LRESULT* pResult);
	CButton addButton;
	afx_msg void OnBnClickedAddButton();
	afx_msg void OnBnClickedDeleteButton();
	CButton deleteButton;
	afx_msg void OnBnClickedRefreshButton();
};
