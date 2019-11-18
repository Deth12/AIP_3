#pragma once
#include <afxdb.h>
#include "MFCACCESSDlg.h"
// Диалоговое окно AddDlg

class AddDlg : public CDialogEx
{
	DECLARE_DYNAMIC(AddDlg)

public:
	AddDlg(CWnd* pParent = nullptr);   // стандартный конструктор
	virtual ~AddDlg();
	bool EstablishConnection();
	void InsertColumns();
	void FillSubjectsTable();
private:

// Данные диалогового окна
#ifdef AFX_DESIGN_TIME
	enum { IDD = IDD_DIALOG1 };
#endif

protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // поддержка DDX/DDV
	virtual BOOL OnInitDialog();
	DECLARE_MESSAGE_MAP()
public:
	CRecordset* recordSet;
	CEdit surnameBox;
	CEdit nameBox;
	CEdit fnameBox;
	CListCtrl subjectsList;
	CListCtrl selectedSubjects;
	afx_msg void OnBnClickedAddSubjectButton();
	afx_msg void OnBnClickedConfirmButton();
	afx_msg void OnDestroy();
};
