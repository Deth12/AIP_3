
// Lab_4.h: главный файл заголовка для приложения PROJECT_NAME
//

#pragma once

#ifndef __AFXWIN_H__
	#error "включить pch.h до включения этого файла в PCH"
#endif

#include "resource.h"		// основные символы


// CLab4App:
// Сведения о реализации этого класса: Lab_4.cpp
//

class CLab4App : public CWinApp
{
public:
	CLab4App();

// Переопределение
public:
	virtual BOOL InitInstance();

// Реализация

	DECLARE_MESSAGE_MAP()
};

extern CLab4App theApp;
