Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
			Me.checkedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.groupControl1.SuspendLayout()
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' groupControl1
			' 
			Me.groupControl1.Controls.Add(Me.checkedListBoxControl1)
			Me.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.groupControl1.Location = New System.Drawing.Point(0, 0)
			Me.groupControl1.Name = "groupControl1"
			Me.groupControl1.Size = New System.Drawing.Size(375, 336)
			Me.groupControl1.TabIndex = 0
			Me.groupControl1.Text = "My TODO"
			' 
			' checkedListBoxControl1
			' 
			Me.checkedListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.checkedListBoxControl1.Location = New System.Drawing.Point(2, 24)
			Me.checkedListBoxControl1.Name = "checkedListBoxControl1"
			Me.checkedListBoxControl1.Size = New System.Drawing.Size(371, 310)
			Me.checkedListBoxControl1.TabIndex = 1
'			Me.checkedListBoxControl1.DrawItem += New DevExpress.XtraEditors.ListBoxDrawItemEventHandler(Me.checkedListBoxControl1_DrawItem);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(375, 336)
			Me.Controls.Add(Me.groupControl1)
			Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.groupControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.groupControl1.ResumeLayout(False)
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private groupControl1 As DevExpress.XtraEditors.GroupControl
		Private WithEvents checkedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl

	End Class
End Namespace

