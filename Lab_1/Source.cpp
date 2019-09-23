#pragma comment(linker,"\"/manifestdependency:type='win32' \
name='Microsoft.Windows.Common-Controls' version='6.0.0.0' \
processorArchitecture='*' publicKeyToken='6595b64144ccf1df' language='*'\"")

#include <Windows.h>

static HWND label0;
static HWND label1;
static HWND label2;
static HWND button;
static HWND textBox1;
static HWND textBox2;

LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);

int CALLBACK wWinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PWSTR szCmdLine, int nCmdShow)
{
	// структура, котора¤ будет содержать в себе инф-цию о сообщени¤х
	MSG msg{};
	// структура, в которой хранитс¤ дескриптор окна (указатель на область пам¤ти в ¤дре)
	HWND hwnd{};
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
	if (hwnd = CreateWindowW(wc.lpszClassName, L"Lab_1", WS_OVERLAPPEDWINDOW, 0, 0, 600, 400, NULL, NULL, wc.hInstance, NULL); hwnd == INVALID_HANDLE_VALUE)
		return EXIT_FAILURE;

	// показ окна
	ShowWindow(hwnd, nCmdShow);
	// обновление окна
	UpdateWindow(hwnd);

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
	const wchar_t helloText[200] = L"Hello, Dmitry Vitalievich.\n1. Enter some text in [Line 1]\n2. Press the button below\n3. [Line 1] -> [Line 2]";
	switch (uMsg)
	{
	case WM_DESTROY:
		PostQuitMessage(EXIT_SUCCESS);
		break;

	case WM_CREATE:
		label0 = CreateWindowW(L"STATIC", helloText, WS_CHILD | WS_VISIBLE | SS_CENTER, 0, 20, 600, 70, hWnd, NULL, NULL, NULL);
		label1 = CreateWindowW(L"STATIC", L"Line 1", WS_CHILD | WS_VISIBLE | SS_CENTER, 0, 100, 600, 20, hWnd, NULL, NULL, NULL);
		label2 = CreateWindowW(L"STATIC", L"Line 2", WS_CHILD | WS_VISIBLE | SS_CENTER, 0, 210, 600, 20, hWnd, NULL, NULL, NULL);

		button = CreateWindowW(L"BUTTON", L"Magic button", WS_CHILD | WS_VISIBLE | BS_PUSHBUTTON, 200, 160, 200, 30, hWnd, reinterpret_cast<HMENU>(1001), NULL, NULL);
		textBox1 = CreateWindowW(L"EDIT", L"", WS_BORDER | WS_CHILD | WS_VISIBLE | !ES_READONLY, 100, 120, 400, 20, hWnd, NULL, NULL, NULL);
		textBox2 = CreateWindowW(L"EDIT", L"", WS_BORDER | WS_CHILD | WS_VISIBLE | ES_READONLY, 100, 230, 400, 20, hWnd, NULL, NULL, NULL);
		break;

	case WM_COMMAND:
		switch (LOWORD(wParam))
		{
		case 1001:
			WCHAR * buffer = new WCHAR[150];
			GetWindowText(textBox1, buffer, 150);
			SetWindowText(textBox2, buffer);
			break;
		}
		break;
	}
	return DefWindowProc(hWnd, uMsg, wParam, lParam);
}