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
	// объект БД
	CDatabase db;
	// переменная для извлечения, навигации по БД
	CRecordset* recordSet;
	// имя источника данных
	CString mDSN;
	CString mConnString;
};

