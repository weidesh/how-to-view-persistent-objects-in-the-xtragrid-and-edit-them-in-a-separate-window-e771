Imports Microsoft.VisualBasic
Imports System

Partial Public Class FormViewOrders
    Private components As System.ComponentModel.IContainer = Nothing

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (Not components Is Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.xpCollection1 = New DevExpress.Xpo.XPCollection
        Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork
        Me.gridControl1 = New DevExpress.XtraGrid.GridControl
        Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.bar1 = New DevExpress.XtraBars.Bar
        Me.barButtonCreate = New DevExpress.XtraBars.BarButtonItem
        Me.barButtonChange = New DevExpress.XtraBars.BarButtonItem
        Me.barButtonDelete = New DevExpress.XtraBars.BarButtonItem
        Me.bar3 = New DevExpress.XtraBars.Bar
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl
        CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xpCollection1
        '
        Me.xpCollection1.DeleteObjectOnRemove = True
        Me.xpCollection1.ObjectType = GetType(XpoEditForm.Order)
        Me.xpCollection1.Session = Me.unitOfWork1
        '
        'gridControl1
        '
        Me.gridControl1.DataSource = Me.xpCollection1
        Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridControl1.EmbeddedNavigator.Name = ""
        Me.gridControl1.Location = New System.Drawing.Point(0, 24)
        Me.gridControl1.MainView = Me.gridView1
        Me.gridControl1.Name = "gridControl1"
        Me.gridControl1.Size = New System.Drawing.Size(660, 422)
        Me.gridControl1.TabIndex = 0
        Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
        '
        'gridView1
        '
        Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOid, Me.colOrderDate, Me.colCustomer})
        Me.gridView1.GridControl = Me.gridControl1
        Me.gridView1.Name = "gridView1"
        Me.gridView1.OptionsBehavior.Editable = False
        Me.gridView1.OptionsDetail.EnableMasterViewMode = False
        '
        'colOid
        '
        Me.colOid.Caption = "Oid"
        Me.colOid.FieldName = "Oid"
        Me.colOid.Name = "colOid"
        Me.colOid.Visible = True
        Me.colOid.VisibleIndex = 0
        Me.colOid.Width = 61
        '
        'colOrderDate
        '
        Me.colOrderDate.Caption = "OrderDate"
        Me.colOrderDate.FieldName = "OrderDate"
        Me.colOrderDate.Name = "colOrderDate"
        Me.colOrderDate.Visible = True
        Me.colOrderDate.VisibleIndex = 1
        Me.colOrderDate.Width = 79
        '
        'colCustomer
        '
        Me.colCustomer.Caption = "Customer"
        Me.colCustomer.FieldName = "Customer"
        Me.colCustomer.Name = "colCustomer"
        Me.colCustomer.Visible = True
        Me.colCustomer.VisibleIndex = 2
        Me.colCustomer.Width = 417
        '
        'barManager1
        '
        Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.bar1, Me.bar3})
        Me.barManager1.DockControls.Add(Me.barDockControlTop)
        Me.barManager1.DockControls.Add(Me.barDockControlBottom)
        Me.barManager1.DockControls.Add(Me.barDockControlLeft)
        Me.barManager1.DockControls.Add(Me.barDockControlRight)
        Me.barManager1.Form = Me
        Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.barButtonCreate, Me.barButtonChange, Me.barButtonDelete})
        Me.barManager1.MaxItemId = 3
        Me.barManager1.StatusBar = Me.bar3
        '
        'bar1
        '
        Me.bar1.BarName = "Custom 2"
        Me.bar1.DockCol = 0
        Me.bar1.DockRow = 0
        Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonCreate), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonChange), New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonDelete)})
        Me.bar1.Text = "Custom 2"
        '
        'barButtonCreate
        '
        Me.barButtonCreate.Caption = "New"
        Me.barButtonCreate.Id = 0
        Me.barButtonCreate.Name = "barButtonCreate"
        '
        'barButtonChange
        '
        Me.barButtonChange.Caption = "Edit"
        Me.barButtonChange.Id = 1
        Me.barButtonChange.Name = "barButtonChange"
        '
        'barButtonDelete
        '
        Me.barButtonDelete.Caption = "Delete"
        Me.barButtonDelete.Id = 2
        Me.barButtonDelete.Name = "barButtonDelete"
        '
        'bar3
        '
        Me.bar3.BarName = "Custom 4"
        Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
        Me.bar3.DockCol = 0
        Me.bar3.DockRow = 0
        Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
        Me.bar3.OptionsBar.AllowQuickCustomization = False
        Me.bar3.OptionsBar.DrawDragBorder = False
        Me.bar3.OptionsBar.UseWholeRow = True
        Me.bar3.Text = "Custom 4"
        Me.bar3.Visible = False
        '
        'FormViewOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 468)
        Me.Controls.Add(Me.gridControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FormViewOrders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order List"
        CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private gridControl1 As DevExpress.XtraGrid.GridControl
    Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Private barManager1 As DevExpress.XtraBars.BarManager
    Private bar1 As DevExpress.XtraBars.Bar
    Private WithEvents barButtonCreate As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barButtonChange As DevExpress.XtraBars.BarButtonItem
    Private WithEvents barButtonDelete As DevExpress.XtraBars.BarButtonItem
    Private bar3 As DevExpress.XtraBars.Bar
    Private barDockControlTop As DevExpress.XtraBars.BarDockControl
    Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Private barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private colOid As DevExpress.XtraGrid.Columns.GridColumn
    Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Private colCustomer As DevExpress.XtraGrid.Columns.GridColumn
    Public WithEvents xpCollection1 As DevExpress.Xpo.XPCollection
    Private unitOfWork1 As DevExpress.Xpo.UnitOfWork

End Class
