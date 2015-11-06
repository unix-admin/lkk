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
        private ComboBox townTypes = new ComboBox();
        private TextBox mkbCodeText = new TextBox();
        private CheckBox isOrphanBox = new CheckBox();
        private Label mkbLabel = new Label();
        private Label orphanLabel = new Label();

        private string regionID;
        private string dataToUpdate;
        private string typeTownToUpdate;
        
        public addData()
        {
            InitializeComponent();
        }
        private void setRegionID(string ID)
        {
            regionID = ID;
        }
        public void setDataToUpdate(string data, string townType)
        {
            dataToUpdate = data;
            valueToEdit.Text = data;
            typeTownToUpdate = townType;
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
                    townTypes.Name = "townType";
                    townTypes.Items.Add("");
                    townTypes.Items.Add("м");
                    townTypes.Items.Add("с");
                    townTypes.Items.Add("смт");
                    townTypes.Items.Add("ст");
                    townTypes.DropDownStyle = ComboBoxStyle.DropDownList;
                    townTypes.Location = new System.Drawing.Point(12, 39);
                    townTypes.Size = new System.Drawing.Size(50, 20);
                    townTypes.TabIndex = 0;
                    this.valueToEdit.Location = new System.Drawing.Point(70, 39);
                    this.valueToEdit.Size = new System.Drawing.Size(380, 20);
                    this.valueToEdit.TabIndex = 1;
                    this.Controls.Add(townTypes);
                    nameValue.Text = "Населений пункт";
                    break;
                case formType.DEPARTMENTS:
                    nameValue.Text = "Відділення";
                    break;
                case formType.DIAGNOSE:
                    nameValue.Text = "Діагноз";
                    repaintToDiagnoseForm();
                    break;
                case formType.DOCTORS:
                    nameValue.Text = "ПІБ Лікаря";
                    break;
                case formType.INFERENCELKK:
                    nameValue.Text = "Висновки ЛКК";
                    break;
                case formType.REGIONS:
                    nameValue.Text = "Район";
                    break;
                case formType.LPZ:
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
                            lkk.addData(Database.typesData.department, valueToEdit.Text);                            
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
                            lkk.addTown(townTypes.Text,regionID,valueToEdit.Text);
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
                                lkk.updateData(Database.typesData.department,dataToUpdate, valueToEdit.Text);
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
                                lkk.updateData(regionID, typeTownToUpdate, townTypes.Text, dataToUpdate, valueToEdit.Text);
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
            this.Controls.Add(mkbLabel);
            mkbCodeText.Location = new Point(12, 39);
            mkbCodeText.Size = new Size(58, 20);
            valueToEdit.Location = new Point(77, 39);
            valueToEdit.Size = new Size(347, 20);
            isOrphanBox.Location = new Point(440, 39);
            mkbLabel.Location = new Point(12, 9);
            mkbLabel.Text = "Код МКХ";
            orphanLabel.Location = new Point(407, 9);
            orphanLabel.Text = "Орфанне";                             
        }

    }
}
