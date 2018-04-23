Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			For i As Integer = 0 To 9
				checkedListBoxControl1.Items.Add(String.Format("Task{0}", i))
			Next i
		End Sub

		Private Sub checkedListBoxControl1_DrawItem(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.ListBoxDrawItemEventArgs) Handles checkedListBoxControl1.DrawItem
			If e.Index Mod 2 = 0 Then
				e.Appearance.BackColor = Color.LightCyan
			Else
				e.Appearance.BackColor = Color.MistyRose
			End If
			If checkedListBoxControl1.GetItemChecked(e.Index) Then
				e.Appearance.BackColor = Color.Gainsboro
				e.Appearance.Font = New Font(e.Appearance.GetFont(), FontStyle.Italic Or FontStyle.Strikeout)
			End If
		End Sub
	End Class
End Namespace