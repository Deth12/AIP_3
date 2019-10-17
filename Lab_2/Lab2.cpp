#pragma comment(linker,"\"/manifestdependency:type='win32' \
name='Microsoft.Windows.Common-Controls' version='6.0.0.0' \
processorArchitecture='*' publicKeyToken='6595b64144ccf1df' language='*'\"")

#include <Windows.h>
#include <cmath>
#include <vector>
#include <string>
#include <strstream>
#include <sstream>
#include <algorithm>

#define MoveTo(hDC, x, y) MoveToEx(hDC, x, y, NULL)

static HWND label0;
static HWND label1;
static HWND label2;
static HWND buttons[5];

float secAngle = 180, minAngle = 180, hourAngle = 180;
bool isTimerActive;
bool clockIsPainted;

LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);

void DrawLines(HWND hWnd, HDC hDC);
void DrawCircleAndEllipse(HWND hWnd, HDC hDC);

void DrawGraph(HWND hWnd, HDC hDC, int scale);
void DrawAxis(HWND hWnd, HDC hDC);
void DrawGrid(HWND hWnd, HDC hDC, int scale);
void DrawNumbers(HWND hWnd, HDC hDC, int scale);

void DrawText(HWND hWnd, HDC hDC);

void DrawClock(HWND hWnd, HDC hDC);
void DrawClockNumbers(HWND hWd, HDC hDC);

int CALLBACK wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PWSTR szCmdLine, int nCmdShow)
{
	// структура, котора¤ будет содержать в себе инф-цию о сообщени¤х
	MSG msg{};
	// структура, в которой хранитс¤ дескриптор окна (указатель на область пам¤ти в ¤дре)
	HWND hWnd{};
	// структура, отвечающа¤ за параметры окна
	WNDCLASSEX wc{ sizeof(WNDCLASSEX) };
	// собсна сами параметры
	// цвет фона
	wc.hbrBackground = CreateSolidBrush(RGB(240, 240, 240));
	// курсор и иконки
	wc.hCursor = LoadCursor(NULL, IDC_ARROW);
	wc.hIcon = LoadIcon(NULL, IDI_APPLICATION);
	wc.hIconSm = LoadIcon(NULL, IDI_APPLICATION);
	// дескриптор экземпл¤ра приложени¤
	wc.hInstance = hInstance;
	// указываем функцию обработки сообщений
	wc.lpfnWndProc = WndProc;
	// название класса
	wc.lpszClassName = L"MyClass";
	// перерисовка окна при изменении размеров
	wc.style = CS_VREDRAW | CS_HREDRAW;
	// проверка успешности регистрации окна
	if (!RegisterClassEx(&wc))
		return EXIT_FAILURE;
	// создание окна
	if (hWnd = CreateWindowW(wc.lpszClassName, L"Lab_2", WS_OVERLAPPEDWINDOW, CW_USEDEFAULT, CW_USEDEFAULT, 600, 500, NULL, NULL, wc.hInstance, NULL), hWnd == INVALID_HANDLE_VALUE)
		return EXIT_FAILURE;
	// структура, хрянящая время (ч, м, с)
	SYSTEMTIME st;
	// заполнение структуры
	GetLocalTime(&st); 
	// установка углов в необходимое положение
	secAngle -= st.wSecond * 6.0f;
	minAngle -= st.wMinute * 6.0f + st.wSecond * 0.1f;
	hourAngle -= st.wHour * 15.0f + st.wMinute * 0.125f;
	SetTimer(hWnd, 1, 1000, NULL);
	// показ окна
	ShowWindow(hWnd, nCmdShow);
	// обновление окна
	UpdateWindow(hWnd);
	// цикл сообщений

	while (GetMessage(&msg, NULL, 0, 0))
	{
		TranslateMessage(&msg);
		DispatchMessage(&msg);
	}
	return EXIT_SUCCESS;
}

LRESULT CALLBACK WndProc(HWND hWnd, UINT uMsg, WPARAM wParam, LPARAM lParam)
{
	const wchar_t description[] = L"1. Draw 8 lines\n2. Draw yellow circle and blue ellipse\n3. Draw graph (y = sin(x))\n4. Fonts\n5. Show timer";
	HDC hDC = NULL;
	std::vector<int>allowedScales = {5,10,20,40};
	int scale = 20;
	switch (uMsg)
	{
	case WM_DESTROY:
		PostQuitMessage(EXIT_SUCCESS);
		break;

	case WM_CREATE:
		buttons[0] = CreateWindowW(L"BUTTON", L"1", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 10, 400, 100, 30, hWnd, (HMENU)(1001), NULL, NULL);
		buttons[1] = CreateWindowW(L"BUTTON", L"2", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 120, 400, 100, 30, hWnd, (HMENU)(1002), NULL, NULL);
		buttons[2] = CreateWindowW(L"BUTTON", L"3", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 230, 400, 100, 30, hWnd, (HMENU)(1003), NULL, NULL);
		buttons[3] = CreateWindowW(L"BUTTON", L"4", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 340, 400, 100, 30, hWnd, (HMENU)(1004), NULL, NULL);
		buttons[4] = CreateWindowW(L"BUTTON", L"5", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 450, 400, 100, 30, hWnd, (HMENU)(1005), NULL, NULL);

		label0 = CreateWindowW(L"STATIC", description, WS_CHILD | WS_VISIBLE | SS_LEFT, 10, 320, 300, 80, hWnd, NULL, NULL, NULL);
		break;

	case WM_TIMER:
		if (secAngle == -180) secAngle = 180;
		// изменение угла секундной стрелки
		secAngle -= 180 / 30.0f;
		if (minAngle == -180) minAngle = 180;
		// изменение угла минутной стрелки
		minAngle -= 180 / 1800.0f;
		if (hourAngle == -180) hourAngle = 180;
		// изменение угла часовой стрелки
		hourAngle -= 180 / 21600.0f;
		DrawClock(hWnd, hDC);
		break;
	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case 1001:
			isTimerActive = false;
			DrawLines(hWnd, hDC);
			break;
		case 1002:
			isTimerActive = false;
			DrawCircleAndEllipse(hWnd, hDC);
			break;
		case 1003:
			isTimerActive = false;
			DrawGraph(hWnd, hDC, scale);
			break;
		case 1004:
			isTimerActive = false;
			DrawText(hWnd, hDC);
			break;
		case 1005:
			isTimerActive = true;
			DrawClock(hWnd, hDC);
			break;
		}
		break;
	}
	return DefWindowProc(hWnd, uMsg, wParam, lParam);
}

void DrawGraph(HWND hWnd, HDC hDC, int scale)
{
	InvalidateRect(hWnd, NULL, TRUE);
	UpdateWindow(hWnd);

	DrawGrid(hWnd, hDC, scale);
	DrawAxis(hWnd, hDC);

	HPEN Pen = CreatePen(PS_SOLID, 3, RGB(255, 0, 0));
	HPEN Pen2 = CreatePen(PS_SOLID, 3, RGB(255, 255, 0));
	HPEN Pen3 = CreatePen(PS_SOLID, 3, RGB(0, 255, 0));


	hDC = GetDC(hWnd);
	SelectObject(hDC, Pen);
	for (float x = -8.00f; x <= 8.00f; x += 0.001f)
	{
		float cX = scale * x + 280.0f;
		float cY = -scale * sin(x) + 160.0f;
		MoveTo(hDC, (int)cX, (int)cY);
		LineTo(hDC, (int)cX, (int)cY);
	}
	SelectObject(hDC, Pen2);
	for (float x = -8.00f; x <= 8.00f; x += 0.001f)
	{
		float cX = scale * x + 280.0f;
		float cY = -scale * cos(x) + 160.0f;
		MoveTo(hDC, (int)cX, (int)cY);
		LineTo(hDC, (int)cX, (int)cY);
	}
	SelectObject(hDC, Pen3);
	for (float x = 0; x <= 8.00f; x += 0.001f)
	{
		float cX = scale * x + 282.0f;
		float cY = -scale * log(x) + 160.0f;
		MoveTo(hDC, (int)cX, (int)cY);
		LineTo(hDC, (int)cX, (int)cY);
	}
	DrawNumbers(hWnd, hDC, scale);
	ReleaseDC(hWnd, hDC);
}

void DrawAxis(HWND hWnd, HDC hDC)
{
	HPEN Pen = CreatePen(PS_SOLID, 3, RGB(0, 0, 0));
	hDC = GetDC(hWnd);
	SetBkMode(hDC, TRANSPARENT);
	SelectObject(hDC, Pen);
	// Draw axis
	MoveTo(hDC, 0, 160);
	LineTo(hDC, 600, 160);
	MoveTo(hDC, 280, 0);
	LineTo(hDC, 280, 300);
	// Axis names
	TextOut(hDC, 290, 10, L"Y", 1);
	TextOut(hDC, 550, 170, L"X", 1);
	ReleaseDC(hWnd, hDC);
}

void DrawGrid(HWND hWnd, HDC hDC, int scale)
{
	HPEN Pen = CreatePen(PS_SOLID, 1, RGB(128, 128, 128));
	hDC = GetDC(hWnd);
	SelectObject(hDC, Pen);
	for (int i = 0; i <= 300; i+=scale)
	{
		MoveTo(hDC, 0, i);
		LineTo(hDC, 600, i);
	}
	for (int i = 0; i <= 600; i += scale)
	{
		MoveTo(hDC, i, 0);
		LineTo(hDC, i, 300);
	}
	ReleaseDC(hWnd, hDC);
}

void DrawNumbers(HWND hWnd, HDC hDC, int scale)
{
	HPEN Pen = CreatePen(PS_SOLID, 3, RGB(0, 0, 255));
	hDC = GetDC(hWnd);
	SelectObject(hDC, Pen);
	int cX = 120;
	int cY = 60;
	SetBkMode(hDC, TRANSPARENT);
	MoveTo(hDC, 280, 158);
	LineTo(hDC, 280, 162);
	TextOut(hDC, 285, 165, L"0", 1);

	for (int i = -8; i <= 8; i++)
	{
		if (i != 0)
		{
			MoveTo(hDC, cX, 158);
			LineTo(hDC, cX, 162);
			TextOut(hDC, cX, 165, std::to_wstring(i).c_str(), 2);
		}
		cX += scale;
	}
	for (int i = 5; i >= -5; i--)
	{
		if (i != 0)
		{
			MoveTo(hDC, 278, cY);
			LineTo(hDC, 282, cY);
			TextOut(hDC, 282, cY, std::to_wstring(i).c_str(), 2);
		}
		cY += scale;
	}
	ReleaseDC(hWnd, hDC);
}

void DrawLines(HWND hWnd, HDC hDC)
{
	InvalidateRect(hWnd, NULL, TRUE);
	UpdateWindow(hWnd);

	HPEN Pen = CreatePen(PS_SOLID, 2, RGB(255, 0, 0));
	hDC = GetDC(hWnd);
	SelectObject(hDC, Pen);
	for (int cY = 20; cY < 320; cY += 40)
	{
		MoveTo(hDC, 0, cY);
		LineTo(hDC, 500, cY);
	}
}

void DrawCircleAndEllipse(HWND hWnd, HDC hDC)
{
	InvalidateRect(hWnd, NULL, TRUE);
	UpdateWindow(hWnd);

	HPEN PenC = CreatePen(PS_SOLID, 3, RGB(255, 255, 0));
	HPEN PenE = CreatePen(PS_SOLID, 3, RGB(0, 0, 255));
	HBRUSH BrushC = CreateSolidBrush(RGB(255, 255, 0));
	HBRUSH BrushE = CreateSolidBrush(RGB(0, 0, 255));
	hDC = GetDC(hWnd);

	SelectObject(hDC, PenC);
	SelectObject(hDC, BrushC);
	Ellipse(hDC, 50, 50, 200, 200);

	SelectObject(hDC, PenE);
	SelectObject(hDC, BrushE);
	Ellipse(hDC, 300, 100, 500, 150);
}

void DrawText(HWND hWnd, HDC hDC)
{
	InvalidateRect(hWnd, NULL, TRUE);
	UpdateWindow(hWnd);

	hDC = GetDC(hWnd);
	SetBkMode(hDC, TRANSPARENT);

	TextOut(hDC, 20, 20, L"Hello world!", 12);

	LOGFONTW lfBold
	{
	lfBold.lfHeight = 24,		/* Высота шрифта */
	lfBold.lfWidth = 0,			/* Ширина шрифта */
	lfBold.lfEscapement = 0,	/* Угол между базовой линией шрифта и координатной осью X*/
	lfBold.lfOrientation = 0,	/* Ориентация символов шрифта*/
	lfBold.lfWeight = 700,		/* Вес, определяет жирность символов */
	lfBold.lfItalic = 1,		/* Курсив */
	lfBold.lfUnderline = 0,		/* Подчеркивание */
	}; 
	HFONT hFont1 = CreateFontIndirect(&lfBold);
	SelectObject(hDC, hFont1);
	TextOut(hDC, 20, 40, L"Hello world!", 12);

	LOGFONTW lfBigger
	{
	lfBigger.lfHeight = 32,		
	lfBigger.lfWidth = 0,			
	lfBigger.lfEscapement = 0,	
	lfBigger.lfOrientation = 0,
	lfBigger.lfWeight = 0,		
	lfBigger.lfItalic = 0,		
	lfBigger.lfUnderline = 0,		
	};
	HFONT hFont2 = CreateFontIndirect(&lfBigger);
	SelectObject(hDC, hFont2);
	TextOut(hDC, 20, 80, L"Hello world!", 12);

	LOGFONTW lfStyle
	{
	lfStyle.lfHeight = 24,		
	lfStyle.lfWidth = 0,			
	lfStyle.lfEscapement = 0,	
	lfStyle.lfOrientation = 0,	
	lfStyle.lfWeight = 0,		
	lfStyle.lfItalic = 1,		
	lfStyle.lfUnderline = 1,		
	};
	HFONT hFont3 = CreateFontIndirect(&lfStyle);
	SelectObject(hDC, hFont3);
	TextOut(hDC, 20, 130, L"Hello world!", 12);

	ReleaseDC(hWnd, hDC);
	
}

void DrawClock(HWND hWnd, HDC hDC)
{
	if (isTimerActive)
	{
		InvalidateRect(hWnd, NULL, TRUE);
		UpdateWindow(hWnd);
		hDC = GetDC(hWnd);
		SetBkMode(hDC, TRANSPARENT);
		// TextOut(hDC, 20, 10, std::to_wstring((int)hourAngle).c_str(), 4);

		Ellipse(hDC, 40, 40, 220, 220);
		HPEN PenS = CreatePen(PS_SOLID, 2, RGB(255, 100, 100));
		HPEN PenM = CreatePen(PS_SOLID, 3, RGB(80, 80, 80));
		HPEN PenH = CreatePen(PS_SOLID, 3, RGB(0, 0, 0));

		DrawClockNumbers(hWnd, hDC);
		// секундная стрелка
		SelectObject(hDC, PenS);
		MoveTo(hDC, 130, 130);
		LineTo(hDC, (int)(130 + 85 * sin(3.1415f * secAngle / 180)), (int)(130 + 85 * cos(3.1415f * secAngle / 180)));

		// минутная стрелка
		SelectObject(hDC, PenM);
		MoveTo(hDC, 130, 130);
		LineTo(hDC, (int)(130 + 80 * sin(3.1415f * minAngle / 180)), (int)(130 + 80 * cos(3.1415f * minAngle / 180)));

		// часовая стрелка
		SelectObject(hDC, PenH);
		MoveTo(hDC, 130, 130);
		LineTo(hDC, (int)(130 + 60 * sin(3.1415f * hourAngle / 180)), (int)(130 + 60 * cos(3.1415f * hourAngle / 180)));

		DeleteObject(PenS);
		DeleteObject(PenM);
		DeleteObject(PenH);
		ReleaseDC(hWnd, hDC);
	}
}
void DrawClockNumbers(HWND hWd, HDC hDC)
{
	HPEN Pen = CreatePen(PS_SOLID, 1, RGB(192, 192, 192));
	LOGFONTW lfStyle
	{
		lfStyle.lfHeight = 18,
		lfStyle.lfWidth = 0,
		lfStyle.lfEscapement = 0,
		lfStyle.lfOrientation = 0,
		lfStyle.lfWeight = 700,
		lfStyle.lfItalic = 0,
		lfStyle.lfUnderline = 0,
	};
	HFONT hFont = CreateFontIndirect(&lfStyle);
	SelectObject(hDC, Pen);
	SelectObject(hDC, hFont);
	int n = 12;
	int offsetX;
	int offsetY;
	for (int i = -180; i < 180; i += 30)
	{
		if (i == -180 || i == 0)
		{
			offsetX = -5;
		}
		else if (i < 0)
		{
			offsetX = -15;
		}
		else if (i > 0)
		{
			offsetX = 5;
		}
		if (i == 90 || i == -90)
		{
			offsetY = -10;
		}
		else if (i > 90 || i < -90)
		{
			offsetY = -20;
		}
		else if (i < 90 || i > -90)
		{
			offsetY = +5;
		}
		MoveTo(hDC, 130, 130);
		int cX = (int)(130 + 90 * sin(3.1415f * i / 180));
		int cY = (int)(130 + 90 * cos(3.1415f * i / 180));
		LineTo(hDC, cX, cY);
		TextOut(hDC, cX + offsetX, cY + offsetY, std::to_wstring(n).c_str(), 2);
		n--;
	}
}
