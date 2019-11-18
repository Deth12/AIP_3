#pragma once
#include <afxdb.h>
class DBControl
{
public:
	DBControl();
	bool OpenConnection();
	void CloseConnection();
	void ExecuteQuery(CString);
	CRecordset* GetRecordset(CString);
private:
	// ������ ��
	CDatabase db;
	// ���������� ��� ����������, ��������� �� ��
	CRecordset* recordSet;
	// ��� ��������� ������
	CString mDSN;
	CString mConnString;
};

