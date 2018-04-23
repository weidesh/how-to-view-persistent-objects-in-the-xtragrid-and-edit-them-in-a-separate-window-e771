Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo

Namespace XpoEditForm
	Partial Public Class FormEditOrder
		Inherits Form
		Private sourceOrder, theOrder As Order
		Private ReadOnly sourceCollection As XPCollection

		Public Sub New(ByVal order As Order, ByVal collection As XPCollection)
			sourceOrder = order
			sourceCollection = collection

			InitializeComponent()

			If sourceOrder Is Nothing Then
				theOrder = New Order(unitOfWork1)
			Else
				theOrder = unitOfWork1.GetObjectByKey(Of Order)(sourceOrder.Oid)
			End If

			xpCollection1.Add(theOrder)
			gridControlOrderDetails.DataSource = theOrder.OrderDetails
		End Sub


		Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
			Close()
		End Sub

		Private Sub btnOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnOK.Click
			gridView1.UpdateCurrentRow()
			BindingContext(xpCollection1).EndCurrentEdit()

			If unitOfWork1.InTransaction Then
				unitOfWork1.CommitChanges()
				If sourceOrder Is Nothing Then
					sourceCollection.Reload()
				Else
					sourceOrder.Reload()
				End If
			End If
			Close()
		End Sub
	End Class
End Namespace