Imports Microsoft.VisualBasic
Imports System

Partial Public Class FormEditOrder
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Codigo generado por el Disenador de Windows Forms"

    Private Sub InitializeComponent()
        Me.textEditOID = New DevExpress.XtraEditors.TextEdit
        Me.xpCollection1 = New DevExpress.Xpo.XPCollection
        Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork
        Me.labelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.labelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.textEditCustomer = New DevExpress.XtraEditors.TextEdit
        Me.btnOK = New DevExpress.XtraEditors.SimpleButton
        Me.btnCancel = New DevExpress.XtraEditors.SimpleButton
        Me.gridControlOrderDetails = New DevExpress.XtraGrid.GridControl
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn
        Me.labelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.dateEditOrderDate = New DevExpress.XtraEditors.DateEdit
        Me.controlNavigator1 = New DevExpress.XtraEditors.ControlNavigator
        CType(Me.textEditOID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControlOrderDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEditOrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dateEditOrderDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'textEditOID
        '
        Me.textEditOID.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Oid", True))
        Me.textEditOID.Location = New System.Drawing.Point(76, 9)
        Me.textEditOID.Name = "textEditOID"
        Me.textEditOID.Properties.AppearanceReadOnly.BackColor = System.Drawing.SystemColors.Control
        Me.textEditOID.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.textEditOID.Properties.ReadOnly = True
        Me.textEditOID.Size = New System.Drawing.Size(100, 20)
        Me.textEditOID.TabIndex = 1
        '
        'xpCollection1
        '
        Me.xpCollection1.LoadingEnabled = False
        Me.xpCollection1.ObjectType = GetType(XpoEditForm.Order)
        Me.xpCollection1.Session = Me.unitOfWork1
        '
        'labelControl1
        '
        Me.labelControl1.Location = New System.Drawing.Point(12, 12)
        Me.labelControl1.Name = "labelControl1"
        Me.labelControl1.Size = New System.Drawing.Size(23, 13)
        Me.labelControl1.TabIndex = 3
        Me.labelControl1.Text = "OID:"
        '
        'labelControl2
        '
        Me.labelControl2.Location = New System.Drawing.Point(197, 12)
        Me.labelControl2.Name = "labelControl2"
        Me.labelControl2.Size = New System.Drawing.Size(50, 13)
        Me.labelControl2.TabIndex = 4
        Me.labelControl2.Text = "Customer:"
        '
        'textEditCustomer
        '
        Me.textEditCustomer.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "Customer", True))
        Me.textEditCustomer.Location = New System.Drawing.Point(287, 9)
        Me.textEditCustomer.Name = "textEditCustomer"
        Me.textEditCustomer.Size = New System.Drawing.Size(211, 20)
        Me.textEditCustomer.TabIndex = 2
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnOK.Location = New System.Drawing.Point(342, 309)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "OK"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(423, 309)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        '
        'gridControlOrderDetails
        '
        Me.gridControlOrderDetails.EmbeddedNavigator.Name = ""
        Me.gridControlOrderDetails.Location = New System.Drawing.Point(12, 105)
        Me.gridControlOrderDetails.MainView = Me.gridView1
        Me.gridControlOrderDetails.Name = "gridControlOrderDetails"
        Me.gridControlOrderDetails.ShowOnlyPredefinedDetails = True
        Me.gridControlOrderDetails.Size = New System.Drawing.Size(486, 195)
        Me.gridControlOrderDetails.TabIndex = 6
        Me.gridControlOrderDetails.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colPrice, Me.colQuantity})
        Me.gridView1.GridControl = Me.gridControlOrderDetails
        Me.gridView1.Name = "gridView1"
        '
        'colProductName
        '
        Me.colProductName.Caption = "ProductName"
        Me.colProductName.FieldName = "ProductName"
        Me.colProductName.Name = "colProductName"
        Me.colProductName.Visible = True
        Me.colProductName.VisibleIndex = 0
        '
        'colPrice
        '
        Me.colPrice.Caption = "Price"
        Me.colPrice.FieldName = "Price"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.Visible = True
        Me.colPrice.VisibleIndex = 1
        '
        'colQuantity
        '
        Me.colQuantity.Caption = "Quantity"
        Me.colQuantity.FieldName = "Quantity"
        Me.colQuantity.Name = "colQuantity"
        Me.colQuantity.Visible = True
        Me.colQuantity.VisibleIndex = 2
        '
        'labelControl3
        '
        Me.labelControl3.Location = New System.Drawing.Point(12, 38)
        Me.labelControl3.Name = "labelControl3"
        Me.labelControl3.Size = New System.Drawing.Size(27, 13)
        Me.labelControl3.TabIndex = 8
        Me.labelControl3.Text = "Date:"
        '
        'dateEditOrderDate
        '
        Me.dateEditOrderDate.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.xpCollection1, "OrderDate", True))
        Me.dateEditOrderDate.EditValue = Nothing
        Me.dateEditOrderDate.Location = New System.Drawing.Point(76, 35)
        Me.dateEditOrderDate.Name = "dateEditOrderDate"
        Me.dateEditOrderDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dateEditOrderDate.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dateEditOrderDate.Size = New System.Drawing.Size(100, 20)
        Me.dateEditOrderDate.TabIndex = 9
        '
        'controlNavigator1
        '
        Me.controlNavigator1.Location = New System.Drawing.Point(12, 75)
        Me.controlNavigator1.Name = "controlNavigator1"
        Me.controlNavigator1.NavigatableControl = Me.gridControlOrderDetails
        Me.controlNavigator1.Size = New System.Drawing.Size(486, 24)
        Me.controlNavigator1.TabIndex = 10
        Me.controlNavigator1.Text = "controlNavigator1"
        '
        'FormEditOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 345)
        Me.Controls.Add(Me.controlNavigator1)
        Me.Controls.Add(Me.dateEditOrderDate)
        Me.Controls.Add(Me.labelControl3)
        Me.Controls.Add(Me.gridControlOrderDetails)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.textEditCustomer)
        Me.Controls.Add(Me.labelControl2)
        Me.Controls.Add(Me.labelControl1)
        Me.Controls.Add(Me.textEditOID)
        Me.Name = "FormEditOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Order"
        CType(Me.textEditOID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControlOrderDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEditOrderDate.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dateEditOrderDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private textEditOID As DevExpress.XtraEditors.TextEdit
    Private labelControl1 As DevExpress.XtraEditors.LabelControl
    Private labelControl2 As DevExpress.XtraEditors.LabelControl
    Private textEditCustomer As DevExpress.XtraEditors.TextEdit
    Private WithEvents btnOK As DevExpress.XtraEditors.SimpleButton
    Private WithEvents btnCancel As DevExpress.XtraEditors.SimpleButton
    Private gridControlOrderDetails As DevExpress.XtraGrid.GridControl
    Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private labelControl3 As DevExpress.XtraEditors.LabelControl
    Private dateEditOrderDate As DevExpress.XtraEditors.DateEdit
    Private controlNavigator1 As DevExpress.XtraEditors.ControlNavigator
    Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
    Private xpCollection1 As DevExpress.Xpo.XPCollection
    Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
    Private colPrice As DevExpress.XtraGrid.Columns.GridColumn
    Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn
End Class