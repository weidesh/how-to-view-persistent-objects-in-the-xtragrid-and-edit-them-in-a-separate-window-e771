Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Xpo

Partial Public Class FormViewOrders
    Inherits Form
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonCreate.ItemClick
        ' New
        EditOrder(Nothing)
    End Sub

    Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonChange.ItemClick
        ' Edit
        EditOrderByRowHandle(gridView1.FocusedRowHandle)
    End Sub

    Private Sub EditOrderByRowHandle(ByVal rowHandle As Integer)
        If rowHandle < 0 Then Exit Sub

        Dim theOrder As Order = CType(gridView1.GetRow(rowHandle), Order)
        EditOrder(theOrder)
    End Sub

    Private Sub EditOrder(ByVal theOrder As Order)
        Dim contactForm As FormEditOrder = New FormEditOrder(theOrder, xpCollection1)
        contactForm.Show()
    End Sub

    Private Sub barButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonDelete.ItemClick
        ' Delete
        If gridView1.FocusedRowHandle < 0 Then
            Return
        End If
        If MessageBox.Show("Delete selected order?", "Confirm deletion", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
            gridView1.DeleteSelectedRows()
            If unitOfWork1.InTransaction Then unitOfWork1.CommitChanges()
        End If
    End Sub

    Private Sub gridView1_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles gridView1.DoubleClick
        Dim pt As Point = gridControl1.PointToClient(MousePosition)
        Dim hitInfo As GridHitInfo = gridView1.CalcHitInfo(pt)
        If hitInfo.InRow Then
            EditOrderByRowHandle(hitInfo.RowHandle)
        End If
    End Sub
End Class