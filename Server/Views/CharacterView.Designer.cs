using System;

namespace Server.Views
{
    partial class CharacterView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
            DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
            AccountLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            PetLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            CharacterGridControl = new DevExpress.XtraGrid.GridControl();
            CharacterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.Caption = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)AccountLookUpEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PetLookUpEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CharacterGridControl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CharacterGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).BeginInit();
            SuspendLayout();
            // 
            // gridColumn6
            // 
            gridColumn6.ColumnEdit = AccountLookUpEdit;
            gridColumn6.FieldName = "Account";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            gridColumn6.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 1;
            // 
            // AccountLookUpEdit
            // 
            AccountLookUpEdit.AutoHeight = false;
            AccountLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            AccountLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            AccountLookUpEdit.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F5);
            AccountLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("EMailAddress", "E-Mail") });
            AccountLookUpEdit.DisplayMember = "EMailAddress";
            AccountLookUpEdit.Name = "AccountLookUpEdit";
            AccountLookUpEdit.NullText = "[Account is null]";
            // 
            // CharacterGridControl
            // 
            CharacterGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            CharacterGridControl.Location = new System.Drawing.Point(0, 0);
            CharacterGridControl.MainView = CharacterGridView;
            CharacterGridControl.Name = "CharacterGridControl";
            CharacterGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] { repositoryItemTextEdit1, AccountLookUpEdit, PetLookUpEdit });
            CharacterGridControl.Size = new System.Drawing.Size(640, 517);
            CharacterGridControl.TabIndex = 0;
            CharacterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { CharacterGridView });
            // 
            // CharacterGridView
            // 
            CharacterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn6, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn7, gridColumn8, Caption, gridColumn10 });
            CharacterGridView.GridControl = CharacterGridControl;
            CharacterGridView.Name = "CharacterGridView";
            CharacterGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.FieldName = "CharacterName";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.FieldName = "Class";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            gridColumn3.FieldName = "Gender";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            gridColumn4.FieldName = "Level";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 4;
            // 
            // gridColumn5
            // 
            gridColumn5.FieldName = "HairType";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 5;
            // 
            // gridColumn7
            // 
            gridColumn7.FieldName = "Deleted";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            gridColumn8.ColumnEdit = repositoryItemTextEdit1;
            gridColumn8.FieldName = "Experience";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 7;
            // 
            // repositoryItemTextEdit1
            // 
            repositoryItemTextEdit1.AutoHeight = false;
            repositoryItemTextEdit1.Mask.EditMask = "#,##0.#";
            repositoryItemTextEdit1.Mask.UseMaskAsDisplayFormat = true;
            repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // gridColumn9
            // 
            gridColumn9.ColumnEdit = repositoryItemTextEdit1;
            gridColumn9.FieldName = "Experience";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 7;
            // 
            // Caption
            // 
            this.Caption.FieldName = "Caption";
            this.Caption.Name = "Caption";
            this.Caption.Visible = true;
            this.Caption.VisibleIndex = 8;
            // 
            // gridColumn10
            // 
            gridColumn10.ColumnEdit = PetLookUpEdit;
            gridColumn10.FieldName = "Pet";
            gridColumn10.Name = "gridColumn10";
            gridColumn10.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            gridColumn10.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            gridColumn10.Visible = true;
            gridColumn10.VisibleIndex = 8;
            // 
            // PetLookUpEdit
            // 
            PetLookUpEdit.AutoHeight = false;
            PetLookUpEdit.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            PetLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            PetLookUpEdit.CloseUpKey = new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F5);
            PetLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MonsterName", "Monster Name") });
            PetLookUpEdit.DisplayMember = "MonsterName";
            PetLookUpEdit.Name = "PetLookUpEdit";
            PetLookUpEdit.NullText = "[Pet is null]";
            // 
            // CharacterView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(640, 517);
            Controls.Add(CharacterGridControl);
            Name = "CharacterView";
            Text = "Character";
            ((System.ComponentModel.ISupportInitialize)AccountLookUpEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)PetLookUpEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)CharacterGridControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)CharacterGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)repositoryItemTextEdit1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl CharacterGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView CharacterGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit AccountLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit PetLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn Caption;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;

    }
}