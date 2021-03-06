﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LKK
{
    public partial class addData : Form
    {
        

        private Database lkk = new Database();
        public enum formType
        {
            DOCTORS = 0
           ,REGIONS
           ,TOWNS
           ,DEPARTMENTS
           ,DIAGNOSE
           ,INFERENCELKK
           ,LPZ
        };
        public enum formAction
        {
            ADD = 0
           , MODIFY
        }
        private formType type;
        private formAction action;        
        private ComboBox dynamicComboBox = new ComboBox();
        private TextBox mkbCodeText = new TextBox();
        private CheckBox isOrphanBox = new CheckBox();
        private Label dynamicLabel = new Label();
        private Label orphanLabel = new Label();
        private DataTable comboBoxItems = new DataTable();
        private string regionID;
        private string dataToUpdate;
        private string typeTownToUpdate;

        public void setRegionID(string regionname)
        {
            regionID = lkk.getID(regionname, Database.typesData.region);
            
        }

        public addData()
        {
            InitializeComponent();
        }
      
        public void setDataToUpdate(string data, string value)
        {
           
            dataToUpdate = data;
            valueToEdit.Text = data;
            typeTownToUpdate = value;
           
        }
        //For Diagnose only
        public void setDataToUpdate(string mkbCode, string diagnose, bool isOrphan)
        {
            dataToUpdate = diagnose;
            valueToEdit.Text = dataToUpdate;
            mkbCodeText.Text = mkbCode;
            isOrphanBox.Checked = isOrphan;
            
        }

        public void setType(formType formTypes, formAction formActions)
        {
            type = formTypes;            
            action = formActions;
        }        

        private void addData_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case formType.TOWNS:
                    this.Text = "Населені пункти";
                    dynamicComboBox.Name = "townType";
                    dynamicComboBox.Items.Add("");
                    dynamicComboBox.Items.Add("м");
                    dynamicComboBox.Items.Add("с");
                    dynamicComboBox.Items.Add("смт");
                    dynamicComboBox.Items.Add("ст");
                    dynamicComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    dynamicComboBox.Location = new System.Drawing.Point(12, 39);
                    dynamicComboBox.Size = new System.Drawing.Size(50, 20);
                    dynamicComboBox.TabIndex = 0;
                    this.valueToEdit.Location = new System.Drawing.Point(70, 39);
                    this.valueToEdit.Size = new System.Drawing.Size(380, 20);
                    this.valueToEdit.TabIndex = 1;
                    this.Controls.Add(dynamicComboBox);
                    nameValue.Text = "Населений пункт";
                    break;
                case formType.DEPARTMENTS:
                    this.Text = "Відділення";
                    nameValue.Text = "Відділення";
                    dynamicComboBox.Size = new Size(162, 20);
                    dynamicComboBox.Sorted = true;
                    dynamicComboBox.Location = new Point(293, 39);
                    dynamicLabel.Location = new Point(293, 9);
                    dynamicLabel.Text = "Зав. відділенням";
                    this.Controls.Add(dynamicComboBox);
                    this.Controls.Add(dynamicLabel);
                    this.valueToEdit.Size = new Size(274, 20);
                    dynamicComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                    dynamicComboBox.DataSource = lkk.getDoctors();
                    dynamicComboBox.DisplayMember = "fio";
                    if (action == formAction.MODIFY)
                        dynamicComboBox.SelectedIndex = dynamicComboBox.FindString(lkk.getHeadOfDepartment(dataToUpdate));
                    break;
                case formType.DIAGNOSE:
                    this.Text = "Діагноз";
                    nameValue.Text = "Діагноз";
                    repaintToDiagnoseForm();
                    break;
                case formType.DOCTORS:
                    this.Text = "Лікарі";
                    nameValue.Text = "ПІБ Лікаря";
                    break;
                case formType.INFERENCELKK:
                    this.Text = "Висновки ЛКК";
                    nameValue.Text = "Висновки ЛКК";
                    break;
                case formType.REGIONS:
                    this.Text = "Райони";
                    nameValue.Text = "Район";
                    break;
                case formType.LPZ:
                    this.Text = "Лікувально - профілактичні заклади";
                    nameValue.Text = "Лікувально-профілактичний заклад";
                    break;
            }
        }

        private void confirn_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case formAction.ADD:
                    switch (type)
                    {
                        case formType.DEPARTMENTS:
                            lkk.addData(valueToEdit.Text, dynamicComboBox.Text);                            
                            break;
                        case formType.DIAGNOSE:
                            lkk.addData(mkbCodeText.Text, valueToEdit.Text, isOrphanBox.Checked);
                                break;
                        case formType.DOCTORS:
                            lkk.addData(Database.typesData.doctor,valueToEdit.Text);
                            break;
                        case formType.INFERENCELKK:
                            lkk.addData(Database.typesData.lkk,valueToEdit.Text);
                            break;
                        case formType.REGIONS:
                            lkk.addData(Database.typesData.region,valueToEdit.Text);
                            break;
                        case formType.TOWNS:
                            lkk.addTown(dynamicComboBox.Text, regionID, valueToEdit.Text);
                            break;
                        case formType.LPZ:
                            lkk.addData(Database.typesData.lpz, valueToEdit.Text);
                            break;
                    }
                    break;
                case formAction.MODIFY:
                    {
                        switch (type)
                        {
                            case formType.DEPARTMENTS:
                                lkk.updateData(dataToUpdate, valueToEdit.Text, dynamicComboBox.Text);                                
                                break;
                            case formType.DIAGNOSE:
                                lkk.updateData(Database.typesData.diagnose, dataToUpdate, valueToEdit.Text);
                                break;
                            case formType.DOCTORS:
                                lkk.updateData(Database.typesData.doctor, dataToUpdate, valueToEdit.Text);
                                break;
                            case formType.INFERENCELKK:
                                lkk.updateData(Database.typesData.lkk, dataToUpdate, valueToEdit.Text);
                                break;
                            case formType.REGIONS:
                                lkk.updateData(Database.typesData.region, dataToUpdate, valueToEdit.Text);
                                break;
                            case formType.TOWNS:
                                lkk.updateData(regionID, typeTownToUpdate, dynamicComboBox.Text, dataToUpdate, valueToEdit.Text);
                                break;
                        }
                        break;
                    }
            }
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void repaintToDiagnoseForm()
        {
            this.Controls.Add(mkbCodeText);
            this.Controls.Add(isOrphanBox);
            this.Controls.Add(orphanLabel);
            this.Controls.Add(dynamicLabel);
            mkbCodeText.Location = new Point(12, 39);
            mkbCodeText.Size = new Size(58, 20);
            valueToEdit.Location = new Point(77, 39);
            valueToEdit.Size = new Size(347, 20);
            isOrphanBox.Location = new Point(440, 39);
            dynamicLabel.Location = new Point(12, 9);
            dynamicLabel.Text = "Код МКХ";
            orphanLabel.Location = new Point(407, 9);
            orphanLabel.Text = "Орфанне";                             
        }

    }
}
