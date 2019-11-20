#pragma once

namespace Lab5 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;
	using namespace System::Text;

	/// <summary>
	/// —водка дл€ MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// ќсвободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::RichTextBox^ inputField1;
	protected:
	private: System::Windows::Forms::RichTextBox^ inputField2;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Button^ magicButton;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::Button^ saveButton;
	private: System::Windows::Forms::Button^ openButton;
	private: System::Windows::Forms::Label^ label6;

	private:
		/// <summary>
		/// ќб€зательна€ переменна€ конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// “ребуемый метод дл€ поддержки конструктора Ч не измен€йте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->inputField1 = (gcnew System::Windows::Forms::RichTextBox());
			this->inputField2 = (gcnew System::Windows::Forms::RichTextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->magicButton = (gcnew System::Windows::Forms::Button());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->saveButton = (gcnew System::Windows::Forms::Button());
			this->openButton = (gcnew System::Windows::Forms::Button());
			this->label6 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// inputField1
			// 
			this->inputField1->Location = System::Drawing::Point(64, 86);
			this->inputField1->Name = L"inputField1";
			this->inputField1->Size = System::Drawing::Size(534, 96);
			this->inputField1->TabIndex = 0;
			this->inputField1->Text = L"";
			// 
			// inputField2
			// 
			this->inputField2->Location = System::Drawing::Point(64, 224);
			this->inputField2->Name = L"inputField2";
			this->inputField2->ReadOnly = true;
			this->inputField2->Size = System::Drawing::Size(534, 96);
			this->inputField2->TabIndex = 1;
			this->inputField2->Text = L"";
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(65, 67);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(216, 16);
			this->label1->TabIndex = 2;
			this->label1->Text = L"Or enter some text in the field below";
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label3->Location = System::Drawing::Point(542, 66);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(56, 16);
			this->label3->TabIndex = 4;
			this->label3->Text = L"[Field 1]";
			// 
			// label4
			// 
			this->label4->AutoSize = true;
			this->label4->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label4->Location = System::Drawing::Point(542, 323);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(56, 16);
			this->label4->TabIndex = 5;
			this->label4->Text = L"[Field 2]";
			// 
			// magicButton
			// 
			this->magicButton->Location = System::Drawing::Point(479, 191);
			this->magicButton->Name = L"magicButton";
			this->magicButton->Size = System::Drawing::Size(119, 23);
			this->magicButton->TabIndex = 6;
			this->magicButton->Text = L"Magic button";
			this->magicButton->UseVisualStyleBackColor = true;
			this->magicButton->Click += gcnew System::EventHandler(this, &MyForm::magicButton_Click);
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label2->Location = System::Drawing::Point(112, 194);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(361, 16);
			this->label2->TabIndex = 7;
			this->label2->Text = L"Click this button to move the text from [Field 1] to [Field 2] --->";
			// 
			// label5
			// 
			this->label5->AutoSize = true;
			this->label5->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label5->Location = System::Drawing::Point(145, 323);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(168, 16);
			this->label5->TabIndex = 8;
			this->label5->Text = L"<--- Click this button to save";
			// 
			// saveButton
			// 
			this->saveButton->Location = System::Drawing::Point(64, 320);
			this->saveButton->Name = L"saveButton";
			this->saveButton->Size = System::Drawing::Size(75, 23);
			this->saveButton->TabIndex = 9;
			this->saveButton->Text = L"Save";
			this->saveButton->UseVisualStyleBackColor = true;
			this->saveButton->Click += gcnew System::EventHandler(this, &MyForm::saveButton_Click);
			// 
			// openButton
			// 
			this->openButton->Location = System::Drawing::Point(64, 28);
			this->openButton->Name = L"openButton";
			this->openButton->Size = System::Drawing::Size(75, 23);
			this->openButton->TabIndex = 10;
			this->openButton->Text = L"Open";
			this->openButton->UseVisualStyleBackColor = true;
			this->openButton->Click += gcnew System::EventHandler(this, &MyForm::openButton_Click);
			// 
			// label6
			// 
			this->label6->AutoSize = true;
			this->label6->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9.75F, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label6->Location = System::Drawing::Point(145, 31);
			this->label6->Name = L"label6";
			this->label6->Size = System::Drawing::Size(315, 16);
			this->label6->TabIndex = 11;
			this->label6->Text = L"<--- Click this button to open a text file and fill [Field 1]";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(657, 386);
			this->Controls->Add(this->label6);
			this->Controls->Add(this->openButton);
			this->Controls->Add(this->saveButton);
			this->Controls->Add(this->label5);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->magicButton);
			this->Controls->Add(this->label4);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->inputField2);
			this->Controls->Add(this->inputField1);
			this->Name = L"MyForm";
			this->Text = L"Lab_5";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void magicButton_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		inputField2->Text = inputField1->Text;
	}

	private: System::Void saveButton_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		if (inputField2->Text != "")
		{
			SaveFileDialog sf;
			sf.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			if (sf.ShowDialog() == System::Windows::Forms::DialogResult::OK)
			{
				File::WriteAllText(sf.FileName, inputField2->Text);
			}
		}
		else
		{
			MessageBox::Show("[Field 2] is empty. Enter some text");
		}
	}

	private: System::Void openButton_Click(System::Object^ sender, System::EventArgs^ e) 
	{
		OpenFileDialog of;
		of.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
		if (of.ShowDialog() == System::Windows::Forms::DialogResult::OK)
		{
			inputField1->Text = File::ReadAllText(of.FileName);
		}
	}
};
}
