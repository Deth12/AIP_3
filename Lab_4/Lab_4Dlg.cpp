
// Lab_4Dlg.cpp: файл реализации
//

#include "pch.h"
#include "framework.h"
#include "Lab_4.h"
#include "Lab_4Dlg.h"
#include "afxdialogex.h"

#include <cmath>
#include <vector>
#include <string>
#include <strstream>
#include <sstream>
#include <algorithm>

#include "mmsystem.h"
#pragma comment(lib,"winmm.lib")

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

// Диалоговое окно CLab4Dlg
void DrawEllipse(CPaintDC& dc);

void DrawGrid(CPaintDC& dc);
void DrawAxis(CPaintDC& dc);
void DrawGraph(CPaintDC& dc);
void DrawNumbers(CPaintDC& dc);

void DrawBigRedText(CPaintDC& dc);

void SoundText(CPaintDC& dc);
int scale = 20;

CLab4Dlg::CLab4Dlg(CWnd* pParent /*=nullptr*/)
	: CDialogEx(IDD_LAB_4_DIALOG, pParent)
{
	m_hIcon = AfxGetApp()->LoadIcon(IDI_ICON1);
	m_hCursor = AfxGetApp()->LoadCursor(IDC_CURSOR1);
}

void CLab4Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialogEx::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CLab4Dlg, CDialogEx)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(Button2, &CLab4Dlg::OnBnClickedButton2)
	ON_BN_CLICKED(Button3, &CLab4Dlg::OnBnClickedButton3)
	ON_BN_CLICKED(Button4, &CLab4Dlg::OnBnClickedButton4)
	ON_BN_CLICKED(ButtonSound, &CLab4Dlg::OnBnClickedButtonsound)
END_MESSAGE_MAP()

// Обработчики сообщений CLab4Dlg

BOOL CLab4Dlg::OnInitDialog()
{
	CDialogEx::OnInitDialog();
	// Устанавливаем курсор
	SetClassLong(m_hWnd, GCL_HCURSOR, (long)m_hCursor);
	// Делаем то же самое для всех элементов управления
	for (int i = 0; i < 0xDFFF; ++i) {
		CWnd* pCtrl = this->GetDlgItem(i);
		if (pCtrl != 0)
			SetClassLong(pCtrl->m_hWnd, GCL_HCURSOR, (long)m_hCursor);
	}
	// Задает значок для этого диалогового окна.  Среда делает это автоматически,
	//  если главное окно приложения не является диалоговым
	SetIcon(m_hIcon, TRUE);			// Крупный значок
	SetIcon(m_hIcon, FALSE);		// Мелкий значок
	// TODO: добавьте дополнительную инициализацию

	return TRUE;  // возврат значения TRUE, если фокус не передан элементу управления
}

// При добавлении кнопки свертывания в диалоговое окно нужно воспользоваться приведенным ниже кодом,
//  чтобы нарисовать значок.  Для приложений MFC, использующих модель документов или представлений,
//  это автоматически выполняется рабочей областью.


void CLab4Dlg::OnPaint()
{
	CPaintDC dc(this);
}


// Система вызывает эту функцию для получения отображения курсора при перемещении
//  свернутого окна.
HCURSOR CLab4Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}


void CLab4Dlg::OnBnClickedButton2()
{
	Invalidate();
	CPaintDC dc(this);
	
	DrawEllipse(dc);
}


void CLab4Dlg::OnBnClickedButton3()
{
	Invalidate(true);
	CPaintDC dc(this);

	DrawGraph(dc);
}

void CLab4Dlg::OnBnClickedButton4()
{
	Invalidate();
	CPaintDC dc(this);

	DrawBigRedText(dc);
}

void CLab4Dlg::OnBnClickedButtonsound()
{
	Invalidate(true);
	CPaintDC dc(this);
	SoundText(dc);
	PlaySound(MAKEINTRESOURCE(IDR_WAVE1), NULL, SND_APPLICATION | SND_ASYNC | SND_RESOURCE);
}

void DrawEllipse(CPaintDC& dc)
{
	HPEN PenC = CreatePen(PS_SOLID, 3, RGB(255, 255, 0));
	HPEN PenE = CreatePen(PS_SOLID, 3, RGB(0, 0, 255));
	HBRUSH BrushC = CreateSolidBrush(RGB(255, 255, 0));
	HBRUSH BrushE = CreateSolidBrush(RGB(0, 0, 255));

	dc.SelectObject(PenC);
	dc.SelectObject(BrushC);
	dc.Ellipse(50, 50, 200, 200);

	dc.SelectObject(PenE);
	dc.SelectObject(BrushE);
	dc.Ellipse(250, 100, 400, 150);
}

void DrawGraph(CPaintDC& dc)
{
	DrawGrid(dc);
	DrawAxis(dc);

	HPEN Pen = CreatePen(PS_SOLID, 4, RGB(255, 0, 0));
	HPEN Pen2 = CreatePen(PS_SOLID, 4, RGB(255, 255, 0));
	HPEN Pen3 = CreatePen(PS_SOLID, 4, RGB(0, 255, 0));

	dc.SelectObject(Pen);
	for (float x = -8.00f; x <= 8.00f; x += 0.1f)
	{
		float cX = scale * x + 280.0f;
		float cY = -scale * sin(x) + 160.0f;
		dc.MoveTo((int)cX, (int)cY);
		dc.LineTo((int)cX, (int)cY);
	}
	dc.SelectObject(Pen2);
	for (float x = -8.00f; x <= 8.00f; x += 0.1f)
	{
		float cX = scale * x + 280.0f;
		float cY = -scale * cos(x) + 160.0f;
		dc.MoveTo((int)cX, (int)cY);
		dc.LineTo((int)cX, (int)cY);
	}
	dc.SelectObject(Pen3);
	for (float x = 0; x <= 8.00f; x += 0.01f)
	{
		float cX = scale * x + 282.0f;
		float cY = -scale * log(x) + 160.0f;
		dc.MoveTo((int)cX, (int)cY);
		dc.LineTo((int)cX, (int)cY);
	}
	DrawNumbers(dc);
}

void DrawGrid(CPaintDC& dc)
{
	HPEN Pen = CreatePen(PS_SOLID, 1, RGB(128, 128, 128));;
	dc.SelectObject(Pen);
	for (int i = 0; i <= 300; i += scale)
	{
		dc.MoveTo(0, i);
		dc.LineTo(600, i);
	}
	for (int i = 0; i <= 600; i += scale)
	{
		dc.MoveTo(i, 0);
		dc.LineTo(i, 300);
	}
}

void DrawAxis(CPaintDC& dc)
{
	HPEN Pen = CreatePen(PS_SOLID, 3, RGB(0, 0, 0));
	dc.SetBkMode(TRANSPARENT);
	dc.SelectObject(Pen);
	// Draw axis
	dc.MoveTo(0, 160);
	dc.LineTo(600, 160);
	dc.MoveTo(280, 0);
	dc.LineTo(280, 300);
	// Axis names
	dc.TextOut(290, 10, L"Y", 1);
	dc.TextOut(550, 170, L"X", 1);
}

void DrawNumbers(CPaintDC& dc)
{
	HPEN Pen = CreatePen(PS_SOLID, 3, RGB(0, 0, 255));
	dc.SelectObject(Pen);
	int cX = 120;
	int cY = 60;
	dc.SetBkMode(TRANSPARENT);
	dc.MoveTo(280, 158);
	dc.LineTo(280, 162);
	dc.TextOut(285, 165, L"0", 1);

	for (int i = -8; i <= 8; i++)
	{
		if (i != 0)
		{
			dc.MoveTo(cX, 158);
			dc.LineTo(cX, 162);
			dc.TextOut(cX, 165, std::to_wstring(i).c_str(), 2);
		}
		cX += scale;
	}
	for (int i = 5; i >= -5; i--)
	{
		if (i != 0)
		{
			dc.MoveTo(278, cY);
			dc.LineTo(282, cY);
			dc.TextOut(282, cY, std::to_wstring(i).c_str(), 2);
		}
		cY += scale;
	}
}

void DrawBigRedText(CPaintDC& dc)
{
	LOGFONTW lf
	{
	lf.lfHeight = 72,		/* Высота шрифта */
	lf.lfWidth = 0,			/* Ширина шрифта */
	lf.lfEscapement = 0,	/* Угол между базовой линией шрифта и координатной осью X*/
	lf.lfOrientation = 0,	/* Ориентация символов шрифта*/
	lf.lfWeight = 700,		/* Вес, определяет жирность символов */
	lf.lfItalic = 0,		/* Курсив */
	lf.lfUnderline = 0,		/* Подчеркивание */
	};
	HFONT hFont1 = CreateFontIndirect(&lf);
	dc.SetTextColor(RGB(255, 0, 0));
	dc.SelectObject(hFont1);
	dc.TextOut(120, 120, L"Hello World!");
}

void SoundText(CPaintDC& dc)
{
	LOGFONTW lf
	{
	lf.lfHeight = 24,		/* Высота шрифта */
	lf.lfWidth = 0,			/* Ширина шрифта */
	lf.lfEscapement = 0,	/* Угол между базовой линией шрифта и координатной осью X*/
	lf.lfOrientation = 0,	/* Ориентация символов шрифта*/
	lf.lfWeight = 700,		/* Вес, определяет жирность символов */
	lf.lfItalic = 1,		/* Курсив */
	lf.lfUnderline = 0,		/* Подчеркивание */
	};
	HFONT hFont1 = CreateFontIndirect(&lf);
	dc.SetTextColor(RGB(0, 0, 0));
	dc.SelectObject(hFont1);
	dc.TextOut(50, 80, L"Human beings are a disease, a cancer of this planet.");
	dc.TextOut(50, 120, L"You're a plague and we are the cure.");
	dc.TextOut(210, 160, L"(C) Agent Smith. The Matrix (1999)");

}

