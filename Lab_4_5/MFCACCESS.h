﻿
// MFCACCESS.h: главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить pch.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы


// CMFCACCESSApp:
// Сведения о реализации этого класса: MFCACCESS.cpp
//

class CMFCACCESSApp : public CWinApp
{
public:
	CMFCACCESSApp();

// Переопределение
public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern CMFCACCESSApp theApp;
