﻿
// Lab_3.h: главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить pch.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы


// CLab3App:
// Сведения о реализации этого класса: Lab_3.cpp
//

class CLab3App : public CWinApp
{
public:
	CLab3App();

// Переопределение
public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern CLab3App theApp;
