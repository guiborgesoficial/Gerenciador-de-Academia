using Business.SqlComandos.Atualizar;
using Business.SqlComandos.Cadastrar;
using Business.SqlComandos.Consultar;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace RCFitness.UserControls
{
    public partial class USC_fichaTreino : UserControl
    {
        public USC_fichaTreino()
        {
            InitializeComponent();
        }

        private void USC_fichaTreino_Load(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void cmbbox_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbox_aluno.SelectedIndex == 0)
            {
                LimpaCheckBox();
                lbl_id.Visible = false;
                lbl_idResult.Visible = false;
                lbl_idResult.Text = "0";
            }
            else
            {
                LimpaCheckBox();
                CS_Matriculados consultaComboBox = new CS_Matriculados();
                consultaComboBox.ConsultadoMatriculados(cmbbox_aluno.Text);
                cmbbox_aluno.Text = consultaComboBox.IDNOVOALUNO.ToString();
                lbl_idResult.Text = consultaComboBox.IDNOVOALUNO.ToString();
                lbl_id.Visible = true;
                lbl_idResult.Visible = true;
            }
        }
        public void LimpaCheckBox()
        {
            aM = "";
            aD = "";
            bM = "";
            bD = "";
            cM = "";
            cD = "";
            dM = "";
            dD = "";
            eM = "";
            eD = "";
            //A_MUSC
            if (chckbox_aMusculo.CheckedItems.Contains("PEITO"))
            {
                chckbox_aMusculo.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_aMusculo.CheckedItems.Contains("OMBROS"))
            {
                chckbox_aMusculo.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_aMusculo.CheckedItems.Contains("BÍCEPS"))
            {
                chckbox_aMusculo.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_aMusculo.CheckedItems.Contains("TRÍCEPS"))
            {
                chckbox_aMusculo.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_aMusculo.CheckedItems.Contains("ANTEBRAÇO"))
            {
                chckbox_aMusculo.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_aMusculo.CheckedItems.Contains("COSTAS"))
            {
                chckbox_aMusculo.SetItemCheckState(5, CheckState.Unchecked);
            }
            if (chckbox_aMusculo.CheckedItems.Contains("ABDÔMEN"))
            {
                chckbox_aMusculo.SetItemCheckState(6, CheckState.Unchecked);
            }
            if (chckbox_aMusculo.CheckedItems.Contains("MEMBROS INFER."))
            {
                chckbox_aMusculo.SetItemCheckState(7, CheckState.Unchecked);
            }        
            //A_DIA        
            if (chckbox_aDias.CheckedItems.Contains("SEGUNDA-FEIRA"))
            {
                chckbox_aDias.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_aDias.CheckedItems.Contains("TERÇA-FEIRA"))
            {
                chckbox_aDias.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_aDias.CheckedItems.Contains("QUARTA-FEIRA"))
            {
                chckbox_aDias.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_aDias.CheckedItems.Contains("QUINTA-FEIRA"))
            {
                chckbox_aDias.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_aDias.CheckedItems.Contains("SEXTA-FEIRA"))
            {
                chckbox_aDias.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_aDias.CheckedItems.Contains("SÁBADO"))
            {
                chckbox_aDias.SetItemCheckState(5, CheckState.Unchecked);
            }
            //B_MUSC
            if(chckbox_bMusculo.CheckedItems.Contains("PEITO"))
            {
                chckbox_bMusculo.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_bMusculo.CheckedItems.Contains("OMBROS"))
            {
                chckbox_bMusculo.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_bMusculo.CheckedItems.Contains("BÍCEPS"))
            {
                chckbox_bMusculo.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_bMusculo.CheckedItems.Contains("TRÍCEPS"))
            {
                chckbox_bMusculo.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_bMusculo.CheckedItems.Contains("ANTEBRAÇO"))
            {
                chckbox_bMusculo.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_bMusculo.CheckedItems.Contains("COSTAS"))
            {
                chckbox_bMusculo.SetItemCheckState(5, CheckState.Unchecked);
            }
            if (chckbox_bMusculo.CheckedItems.Contains("ABDÔMEN"))
            {
                chckbox_bMusculo.SetItemCheckState(6, CheckState.Unchecked);
            }
            if (chckbox_bMusculo.CheckedItems.Contains("MEMBROS INFER."))
            {
                chckbox_bMusculo.SetItemCheckState(7, CheckState.Unchecked);
            }     
            //B_DIA
            if (chckbox_bDias.CheckedItems.Contains("SEGUNDA-FEIRA"))
            {
                chckbox_bDias.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_bDias.CheckedItems.Contains("TERÇA-FEIRA"))
            {
                chckbox_bDias.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_bDias.CheckedItems.Contains("QUARTA-FEIRA"))
            {
                chckbox_bDias.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_bDias.CheckedItems.Contains("QUINTA-FEIRA"))
            {
                chckbox_bDias.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_bDias.CheckedItems.Contains("SEXTA-FEIRA"))
            {
                chckbox_bDias.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_bDias.CheckedItems.Contains("SÁBADO"))
            {
                chckbox_bDias.SetItemCheckState(5, CheckState.Unchecked);
            }
            //C_MUSC
            if (chckbox_cMusculo.CheckedItems.Contains("PEITO"))
            {
                chckbox_cMusculo.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_cMusculo.CheckedItems.Contains("OMBROS"))
            {
                chckbox_cMusculo.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_cMusculo.CheckedItems.Contains("BÍCEPS"))
            {
                chckbox_cMusculo.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_cMusculo.CheckedItems.Contains("TRÍCEPS"))
            {
                chckbox_cMusculo.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_cMusculo.CheckedItems.Contains("ANTEBRAÇO"))
            {
                chckbox_cMusculo.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_cMusculo.CheckedItems.Contains("COSTAS"))
            {
                chckbox_cMusculo.SetItemCheckState(5, CheckState.Unchecked);
            }
            if (chckbox_cMusculo.CheckedItems.Contains("ABDÔMEN"))
            {
                chckbox_cMusculo.SetItemCheckState(6, CheckState.Unchecked);
            }
            if (chckbox_cMusculo.CheckedItems.Contains("MEBROS INFER."))
            {
                chckbox_cMusculo.SetItemCheckState(7, CheckState.Unchecked);
            }  
            //C_DIA
            if (chckbox_cDias.CheckedItems.Contains("SEGUNDA-FEIRA"))
            {
                chckbox_cDias.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_cDias.CheckedItems.Contains("TERÇA-FEIRA"))
            {
                chckbox_cDias.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_cDias.CheckedItems.Contains("QUARTA-FEIRA"))
            {
                chckbox_cDias.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_cDias.CheckedItems.Contains("QUINTA-FEIRA"))
            {
                chckbox_cDias.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_cDias.CheckedItems.Contains("SEXTA-FEIRA"))
            {
                chckbox_cDias.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_cDias.CheckedItems.Contains("SÁBADO"))
            {
                chckbox_cDias.SetItemCheckState(5, CheckState.Unchecked);
            }
            //D_MUSC
            if (chckbox_dMusculo.CheckedItems.Contains("PEITO"))
            {
                chckbox_dMusculo.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_dMusculo.CheckedItems.Contains("OMBROS"))
            {
                chckbox_dMusculo.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_dMusculo.CheckedItems.Contains("BÍCEPS"))
            {
                chckbox_dMusculo.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_dMusculo.CheckedItems.Contains("TRÍCEPS"))
            {
                chckbox_dMusculo.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_dMusculo.CheckedItems.Contains("ANTEBRAÇO"))
            {
                chckbox_dMusculo.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_dMusculo.CheckedItems.Contains("COSTAS"))
            {
                chckbox_dMusculo.SetItemCheckState(5, CheckState.Unchecked);
            }
            if (chckbox_dMusculo.CheckedItems.Contains("ABDÔMEN"))
            {
                chckbox_dMusculo.SetItemCheckState(6, CheckState.Unchecked);
            }
            if (chckbox_dMusculo.CheckedItems.Contains("MEBROS INFER."))
            {
                chckbox_dMusculo.SetItemCheckState(7, CheckState.Unchecked);
            }       
            //D_DIA
            if (chckbox_dDias.CheckedItems.Contains("SEGUNDA-FEIRA"))
            {
                chckbox_dDias.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_dDias.CheckedItems.Contains("TERÇA-FEIRA"))
            {
                chckbox_dDias.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_dDias.CheckedItems.Contains("QUARTA-FEIRA"))
            {
                chckbox_dDias.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_dDias.CheckedItems.Contains("QUINTA-FEIRA"))
            {
                chckbox_dDias.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_dDias.CheckedItems.Contains("SEXTA-FEIRA"))
            {
                chckbox_dDias.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_dDias.CheckedItems.Contains("SÁBADO"))
            {
                chckbox_dDias.SetItemCheckState(5, CheckState.Unchecked);
            }
            //E_MUSC
            if (chckbox_eMusculo.CheckedItems.Contains("PEITO"))
            {
                chckbox_eMusculo.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_eMusculo.CheckedItems.Contains("OMBROS"))
            {
                chckbox_eMusculo.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_eMusculo.CheckedItems.Contains("BÍCEPS"))
            {
                chckbox_eMusculo.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_eMusculo.CheckedItems.Contains("TRÍCEPS"))
            {
                chckbox_eMusculo.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_eMusculo.CheckedItems.Contains("ANTEBRAÇO"))
            {
                chckbox_eMusculo.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_eMusculo.CheckedItems.Contains("COSTAS"))
            {
                chckbox_eMusculo.SetItemCheckState(5, CheckState.Unchecked);
            }
            if (chckbox_eMusculo.CheckedItems.Contains("ABDÔMEN"))
            {
                chckbox_eMusculo.SetItemCheckState(6, CheckState.Unchecked);
            }
            if (chckbox_eMusculo.CheckedItems.Contains("MEBROS INFER."))
            {
                chckbox_eMusculo.SetItemCheckState(7, CheckState.Unchecked);
            }          
            //E_DIA
            if (chckbox_eDias.CheckedItems.Contains("SEGUNDA-FEIRA"))
            {
                chckbox_eDias.SetItemCheckState(0, CheckState.Unchecked);
            }
            if (chckbox_eDias.CheckedItems.Contains("TERÇA-FEIRA"))
            {
                chckbox_eDias.SetItemCheckState(1, CheckState.Unchecked);
            }
            if (chckbox_eDias.CheckedItems.Contains("QUARTA-FEIRA"))
            {
                chckbox_eDias.SetItemCheckState(2, CheckState.Unchecked);
            }
            if (chckbox_eDias.CheckedItems.Contains("QUINTA-FEIRA"))
            {
                chckbox_eDias.SetItemCheckState(3, CheckState.Unchecked);
            }
            if (chckbox_eDias.CheckedItems.Contains("SEXTA-FEIRA"))
            {
                chckbox_eDias.SetItemCheckState(4, CheckState.Unchecked);
            }
            if (chckbox_eDias.CheckedItems.Contains("SÁBADO"))
            {
                chckbox_eDias.SetItemCheckState(5, CheckState.Unchecked);
            }
        }
        private void cmbbox_aluno_MouseClick(object sender, MouseEventArgs e)
        {
            cmbbox_aluno.Items.Clear();
            chckbox_bDias.SelectedItems.Clear();         
            cmbbox_aluno.Items.Add("");
            CS_Matriculados retornarItensArray = new CS_Matriculados();
            retornarItensArray.ConsultaParaComboBox();
            cmbbox_aluno.Items.AddRange(retornarItensArray.tabela.ToArray());
        }
        string aM = "";
        string aD = "";
        string bM = "";
        string bD = "";
        string cM = "";
        string cD = "";
        string dM = "";
        string dD = "";
        string eM = "";
        string eD = "";
        string somaConcatenaTesteDia = "";
        string somaConcatenaTesteMusculo = "";
        public void Concatenar()
        {          
            List<string> aMusculo = new List<string>();
            foreach (string itens in chckbox_aMusculo.CheckedItems)
            {
                aMusculo.Add(itens);
            }
            List<string> aDia = new List<string>();
            foreach (string itens in chckbox_aDias.CheckedItems)
            {
                aDia.Add(itens);
            }
            List<string> bMusculo = new List<string>();
            foreach (string itens in chckbox_bMusculo.CheckedItems)
            {
                bMusculo.Add(itens);
            }
            List<string> bDia = new List<string>();
            foreach (string itens in chckbox_bDias.CheckedItems)
            {
                bDia.Add(itens);
            }
            List<string> cMusculo = new List<string>();
            foreach (string itens in chckbox_cMusculo.CheckedItems)
            {
                cMusculo.Add(itens);
            }
            List<string> cDia = new List<string>();
            foreach (string itens in chckbox_cDias.CheckedItems)
            {
                cDia.Add(itens);
            }
            List<string> dMusculo = new List<string>();
            foreach (string itens in chckbox_dMusculo.CheckedItems)
            {
                dMusculo.Add(itens);
            }
            List<string> dDia = new List<string>();
            foreach (string itens in chckbox_dDias.CheckedItems)
            {
                dDia.Add(itens);
            }
            List<string> eMusculo = new List<string>();
            foreach (string itens in chckbox_eMusculo.CheckedItems)
            {
                eMusculo.Add(itens);
            }
            List<string> eDia = new List<string>();
            foreach (string itens in chckbox_eDias.CheckedItems)
            {
                eDia.Add(itens);
            }

            //Concatenando

            for (int i = 0; i < aMusculo.Count; i++)
            {
                aM += "/" + aMusculo[i];
            }
            for (int i = 0; i < aDia.Count; i++)
            {
                aD += "/" + aDia[i];
            }
            for (int i = 0; i < bMusculo.Count; i++)
            {
                bM += "/" + bMusculo[i];
            }
            for (int i = 0; i < bDia.Count; i++)
            {
                bD += "/" + bDia[i];
            }
            for (int i = 0; i < cMusculo.Count; i++)
            {
                cM += "/" + cMusculo[i];
            }
            for (int i = 0; i < cDia.Count; i++)
            {
                cD += "/" + cDia[i];
            }
            for (int i = 0; i < dMusculo.Count; i++)
            {
                dM += "/" + dMusculo[i];
            }
            for (int i = 0; i < dDia.Count; i++)
            {
                dD += "/" + dDia[i];
            }
            for (int i = 0; i < eMusculo.Count; i++)
            {
                eM += "/" + eMusculo[i];
            }
            for (int i = 0; i < eDia.Count; i++)
            {
                eD += "/" + eDia[i];
            }
            somaConcatenaTesteDia = aD + bD + cD + dD + eD;
            somaConcatenaTesteMusculo = aM + bM + cM + dM + eM;
        }
        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if(lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                Concatenar();
                
                if(!string.IsNullOrEmpty(somaConcatenaTesteDia) && !string.IsNullOrEmpty(somaConcatenaTesteMusculo))
                {
                    CD_FichaDeTreino cadastrarFichaTreino = new CD_FichaDeTreino();
                    cadastrarFichaTreino.InserindoFichaDeTreino(aM, aD, bM, bD, cM, cD, dM, dD, eM, eD, lbl_idResult.Text);
                }
                else
                {
                    MessageBox.Show("É necessário selecionar um grupamento muscular e um dia para cadastrar uma ficha de treino", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }   
            else
            {
                MessageBox.Show("É necessário selecionar um aluno para cadastrar a ficha de treino", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            if(lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                RetornandoCheckBox();
            }
            else
            {
                MessageBox.Show("É necessário selecionar um aluno para consultar a ficha de treino", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void RetornandoCheckBox()
        {
            CS_FichaDeTreino novo = new CS_FichaDeTreino();
            novo.ConsultandoFichaDeTreino(lbl_idResult.Text);
                        
            //A_MUSC
            if(novo.verificadorExisteDados)
            {
                if (novo.A_MUSC.Contains("PEITO"))
                {
                    chckbox_aMusculo.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.A_MUSC.Contains("OMBROS"))
                {
                    chckbox_aMusculo.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.A_MUSC.Contains("BÍCEPS"))
                {
                    chckbox_aMusculo.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.A_MUSC.Contains("TRÍCEPS"))
                {
                    chckbox_aMusculo.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.A_MUSC.Contains("ANTEBRAÇO"))
                {
                    chckbox_aMusculo.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.A_MUSC.Contains("COSTAS"))
                {
                    chckbox_aMusculo.SetItemCheckState(5, CheckState.Checked);
                }
                if (novo.A_MUSC.Contains("ABDÔMEN"))
                {
                    chckbox_aMusculo.SetItemCheckState(6, CheckState.Checked);
                }
                if (novo.A_MUSC.Contains("MEBROS INFER."))
                {
                    chckbox_aMusculo.SetItemCheckState(7, CheckState.Checked);
                }

                //A_DIA

                if (novo.A_DIA.Contains("SEGUNDA-FEIRA"))
                {
                    chckbox_aDias.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.A_DIA.Contains("TERÇA-FEIRA"))
                {
                    chckbox_aDias.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.A_DIA.Contains("QUARTA-FEIRA"))
                {
                    chckbox_aDias.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.A_DIA.Contains("QUINTA-FEIRA"))
                {
                    chckbox_aDias.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.A_DIA.Contains("SEXTA-FEIRA"))
                {
                    chckbox_aDias.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.A_DIA.Contains("SÁBADO"))
                {
                    chckbox_aDias.SetItemCheckState(5, CheckState.Checked);
                }

                //B_MUSC

                if (novo.B_MUSC.Contains("PEITO"))
                {
                    chckbox_bMusculo.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.B_MUSC.Contains("OMBROS"))
                {
                    chckbox_bMusculo.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.B_MUSC.Contains("BÍCEPS"))
                {
                    chckbox_bMusculo.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.B_MUSC.Contains("TRÍCEPS"))
                {
                    chckbox_bMusculo.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.B_MUSC.Contains("ANTEBRAÇO"))
                {
                    chckbox_bMusculo.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.B_MUSC.Contains("COSTAS"))
                {
                    chckbox_bMusculo.SetItemCheckState(5, CheckState.Checked);
                }
                if (novo.B_MUSC.Contains("ABDÔMEN"))
                {
                    chckbox_bMusculo.SetItemCheckState(6, CheckState.Checked);
                }
                if (novo.B_MUSC.Contains("MEBROS INFER."))
                {
                    chckbox_bMusculo.SetItemCheckState(7, CheckState.Checked);
                }

                //B_DIA

                if (novo.B_DIA.Contains("SEGUNDA-FEIRA"))
                {
                    chckbox_bDias.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.B_DIA.Contains("TERÇA-FEIRA"))
                {
                    chckbox_bDias.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.B_DIA.Contains("QUARTA-FEIRA"))
                {
                    chckbox_bDias.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.B_DIA.Contains("QUINTA-FEIRA"))
                {
                    chckbox_bDias.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.B_DIA.Contains("SEXTA-FEIRA"))
                {
                    chckbox_bDias.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.B_DIA.Contains("SÁBADO"))
                {
                    chckbox_bDias.SetItemCheckState(5, CheckState.Checked);
                }

                //C_MUSC

                if (novo.C_MUSC.Contains("PEITO"))
                {
                    chckbox_cMusculo.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.C_MUSC.Contains("OMBROS"))
                {
                    chckbox_cMusculo.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.C_MUSC.Contains("BÍCEPS"))
                {
                    chckbox_cMusculo.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.C_MUSC.Contains("TRÍCEPS"))
                {
                    chckbox_cMusculo.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.C_MUSC.Contains("ANTEBRAÇO"))
                {
                    chckbox_cMusculo.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.C_MUSC.Contains("COSTAS"))
                {
                    chckbox_cMusculo.SetItemCheckState(5, CheckState.Checked);
                }
                if (novo.C_MUSC.Contains("ABDÔMEN"))
                {
                    chckbox_cMusculo.SetItemCheckState(6, CheckState.Checked);
                }
                if (novo.C_MUSC.Contains("MEBROS INFER."))
                {
                    chckbox_cMusculo.SetItemCheckState(7, CheckState.Checked);
                }

                //B_DIA

                if (novo.C_DIA.Contains("SEGUNDA-FEIRA"))
                {
                    chckbox_cDias.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.C_DIA.Contains("TERÇA-FEIRA"))
                {
                    chckbox_cDias.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.C_DIA.Contains("QUARTA-FEIRA"))
                {
                    chckbox_cDias.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.C_DIA.Contains("QUINTA-FEIRA"))
                {
                    chckbox_cDias.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.C_DIA.Contains("SEXTA-FEIRA"))
                {
                    chckbox_cDias.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.C_DIA.Contains("SÁBADO"))
                {
                    chckbox_cDias.SetItemCheckState(5, CheckState.Checked);
                }

                //D_MUSC

                if (novo.D_MUSC.Contains("PEITO"))
                {
                    chckbox_dMusculo.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.D_MUSC.Contains("OMBROS"))
                {
                    chckbox_dMusculo.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.D_MUSC.Contains("BÍCEPS"))
                {
                    chckbox_dMusculo.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.D_MUSC.Contains("TRÍCEPS"))
                {
                    chckbox_dMusculo.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.D_MUSC.Contains("ANTEBRAÇO"))
                {
                    chckbox_dMusculo.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.D_MUSC.Contains("COSTAS"))
                {
                    chckbox_dMusculo.SetItemCheckState(5, CheckState.Checked);
                }
                if (novo.D_MUSC.Contains("ABDÔMEN"))
                {
                    chckbox_dMusculo.SetItemCheckState(6, CheckState.Checked);
                }
                if (novo.D_MUSC.Contains("MEBROS INFER."))
                {
                    chckbox_dMusculo.SetItemCheckState(7, CheckState.Checked);
                }

                //D_DIA

                if (novo.D_DIA.Contains("SEGUNDA-FEIRA"))
                {
                    chckbox_dDias.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.D_DIA.Contains("TERÇA-FEIRA"))
                {
                    chckbox_dDias.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.D_DIA.Contains("QUARTA-FEIRA"))
                {
                    chckbox_dDias.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.D_DIA.Contains("QUINTA-FEIRA"))
                {
                    chckbox_dDias.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.D_DIA.Contains("SEXTA-FEIRA"))
                {
                    chckbox_dDias.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.D_DIA.Contains("SÁBADO"))
                {
                    chckbox_dDias.SetItemCheckState(5, CheckState.Checked);
                }

                //E_MUSC

                if (novo.E_MUSC.Contains("PEITO"))
                {
                    chckbox_eMusculo.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.E_MUSC.Contains("OMBROS"))
                {
                    chckbox_eMusculo.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.E_MUSC.Contains("BÍCEPS"))
                {
                    chckbox_eMusculo.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.E_MUSC.Contains("TRÍCEPS"))
                {
                    chckbox_eMusculo.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.E_MUSC.Contains("ANTEBRAÇO"))
                {
                    chckbox_eMusculo.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.E_MUSC.Contains("COSTAS"))
                {
                    chckbox_eMusculo.SetItemCheckState(5, CheckState.Checked);
                }
                if (novo.E_MUSC.Contains("ABDÔMEN"))
                {
                    chckbox_eMusculo.SetItemCheckState(6, CheckState.Checked);
                }
                if (novo.E_MUSC.Contains("MEBROS INFER."))
                {
                    chckbox_eMusculo.SetItemCheckState(7, CheckState.Checked);
                }

                //E_DIA

                if (novo.E_DIA.Contains("SEGUNDA-FEIRA"))
                {
                    chckbox_eDias.SetItemCheckState(0, CheckState.Checked);
                }
                if (novo.E_DIA.Contains("TERÇA-FEIRA"))
                {
                    chckbox_eDias.SetItemCheckState(1, CheckState.Checked);
                }
                if (novo.E_DIA.Contains("QUARTA-FEIRA"))
                {
                    chckbox_eDias.SetItemCheckState(2, CheckState.Checked);
                }
                if (novo.E_DIA.Contains("QUINTA-FEIRA"))
                {
                    chckbox_eDias.SetItemCheckState(3, CheckState.Checked);
                }
                if (novo.E_DIA.Contains("SEXTA-FEIRA"))
                {
                    chckbox_eDias.SetItemCheckState(4, CheckState.Checked);
                }
                if (novo.E_DIA.Contains("SÁBADO"))
                {
                    chckbox_eDias.SetItemCheckState(5, CheckState.Checked);
                }
            }
            else
            {
                MessageBox.Show("Não há nenhuma ficha de treino cadastrada para esse aluno", "Sem Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_gerarPDF_Click(object sender, EventArgs e)
        {
            using(var image = new Bitmap(pnl_print.Width, pnl_print.Height))
            {
                string caminho = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\";
                pnl_print.DrawToBitmap(image, new Rectangle(0, 0, image.Width, image.Height));
                image.Save(caminho + "Ficha De Treino - " + cmbbox_aluno.Text + ".png", ImageFormat.Png);
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            Concatenar();
            if(lbl_idResult.Text != "0" && lbl_idResult.Text != "ID:")
            {
                UP_FichaTreino atualizar = new UP_FichaTreino();
                atualizar.AtualizarFichaTreino(aM, aD, bM, bD, cM, cD, dM, dD, eM, eD, lbl_idResult.Text);
            }
            else
            {
                MessageBox.Show("Realize uma consulta antes de atualizar uma ficha de treino.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
