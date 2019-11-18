#include "pch.h"
#include "DBControl.h"

DBControl::DBControl()
{
	mDSN = L"MS Access Database";
	mConnString = L"ODBC;DRIVER=Microsoft Access Driver (*.mdb, *.accdb); DBQ=.\\Data.accdb";
}

bool DBControl::OpenConnection()
{
	if (!db.Open(mDSN, FALSE, FALSE, mConnString))
	{
		AfxMessageBox(L"Ошибка открытия БД", MB_ICONSTOP);
		return false;
	}
	else
	{
		return true;
	}
}

void DBControl::CloseConnection()
{
	if (db.IsOpen())
	{
		db.Close();
	}
}

void DBControl::ExecuteQuery(CString query)
{
	db.ExecuteSQL(query);
}

CRecordset* DBControl::GetRecordset(CString query)
{
	recordSet = new CRecordset(&db);
	recordSet->Open(AFX_DB_USE_DEFAULT_TYPE, query, CRecordset::readOnly);
	return recordSet;
}
