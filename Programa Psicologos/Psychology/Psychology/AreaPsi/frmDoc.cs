using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
   
  


namespace Psychology
{
    public partial class frmDoc : Form
    {
        public frmDoc()
        {
            InitializeComponent();
           
        }
        

       String cidade, dia, mes, ano, nomedoc, paciente, diagnostico, psicologo, crp,
           solicitante, tempoAf, sintomas, razao, iniT, diaSe, horarioSe,
           interessado, assunto, introducao, descricao, conclusao,
           exMotivos, discussao, solicitantep, assuntop,
             dtnasc, idade, estCivil, esco, profi, solicitantel, finalidade, demanda, tecnicas, respo;

       private void getInfo()
       {
           
           cidade = txtCidade.Text;           
           dia = txtDia.Text;
           mes = txtMes.Text;
           ano = DateTime.Now.ToString("yyyy");

           nomedoc = txtNomeD.Text;

           paciente = txtPac.Text;
           diagnostico = txtDiag.Text;
           psicologo = txtPsi.Text;
           crp = TxtCRP.Text;

           solicitante = txtSolici.Text;
           tempoAf = txtTempoAf.Text;
           sintomas = txtSintomas.Text;
           razao = txtRazao.Text;
           iniT = txtIniTera.Text;
           diaSe = txtDiaSe.Text;
           horarioSe = txtHoraSe.Text;

           interessado = txtInteressado.Text;
           assunto = txtAssunto.Text;
           introducao = txtintrodu.Text;
           descricao = txtDesc.Text;
           conclusao = txtConclu.Text;

           exMotivos = txtExMotiv.Text;
           discussao = txtDiscu.Text;
           solicitantep = txtSolicP.Text;
           assuntop = txtAssuntoP.Text;

           dtnasc = txtDtNasc.Text;
           idade= txtIdade.Text;
           estCivil = txtEstCi.Text;
           esco = txtEsco.Text;
           profi = txtProf.Text;
           solicitantel= txtSoliL.Text;
           finalidade = txtFinalidade.Text;
           demanda = txtDemanda.Text;
           tecnicas = txtTecnicas.Text;
           respo = txtResp.Text;


       }

        private void btnCriar_Click(object sender, System.EventArgs e)
        {
           
           
       }

        private void panel1_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void btnCriarAt1_Click(object sender, System.EventArgs e)
        {
            getInfo();


            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            try
            {
                // cria o arquivo pdf
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomedoc + ".pdf", FileMode.Create));

                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                Font.FontFamily familha = new Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                Font fonte = new Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                Font fonte1 = new Font(familha, 12, (int)System.Drawing.FontStyle.Regular);









                // abre o documento para começar a escrever o pdf
                document.Open();

                // aqui faz um for para simular diversas linhas de um relatorio
                for (int i = 0; i < 1; i++)
                {
                    // adiciona um novo paragrafo com o texto da respectiva linha.
                    document.Add(new Paragraph("ATESTADO", fonte));
                    Paragraph paragrafo1 = new Paragraph("Atesto, para os devidos fins, que o Sr. " + paciente +
                        " encontra-se em acompanhamento psicológico para tratar de sintomas compatíveis com " + diagnostico, fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo1);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));
                    Paragraph paragrafo2 = new Paragraph("Nome da " + cidade + ", " + dia + "," + mes + "," + ano, fonte1);
                    paragrafo2.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo2);
                    Paragraph paragrafo3 = new Paragraph(psicologo, fonte1);
                    paragrafo3.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo3);
                    Paragraph paragrafo4 = new Paragraph(crp, fonte1);
                    paragrafo4.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo4);


                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }


            // fecha o documento
            document.Close();

            // manda abrir o pdf
            Process.Start(nomedoc + ".pdf");
        }

        private void btnCriarAt2_Click(object sender, System.EventArgs e)
        {
            getInfo();


            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            try
            {
                // cria o arquivo pdf
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomedoc + ".pdf", FileMode.Create));

                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                Font.FontFamily familha = new Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                Font fonte = new Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                Font fonte1 = new Font(familha, 12, (int)System.Drawing.FontStyle.Regular);









                // abre o documento para começar a escrever o pdf
                document.Open();

                // aqui faz um for para simular diversas linhas de um relatorio
                for (int i = 0; i < 1; i++)
                {
                    // adiciona um novo paragrafo com o texto da respectiva linha.
                    document.Add(new Paragraph("ATESTADO", fonte));
                    Paragraph paragrafo1 = new Paragraph("Atesto, para fins de comprovação junto a "
                        + solicitante + ", que o Sr." + paciente + ", apresenta sintomas relativos a " + sintomas 
                        + ", necessitando, no momento, de" + tempoAf 
                        +" de afastamento de suas atividades laborais para  acompanhamento " 
                        + razao + ".", fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo1);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));
                    Paragraph paragrafo2 = new Paragraph("Nome da " + cidade + ", " + dia + "," + mes + "," + ano, fonte1);
                    paragrafo2.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo2);
                    Paragraph paragrafo3 = new Paragraph(psicologo, fonte1);
                    paragrafo3.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo3);
                    Paragraph paragrafo4 = new Paragraph(crp, fonte1);
                    paragrafo4.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo4);


                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }


            // fecha o documento
            document.Close();

            // manda abrir o pdf
            Process.Start(nomedoc + ".pdf");

        }

        private void btnCriarDec1_Click(object sender, System.EventArgs e)
        {
            getInfo();


            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            try
            {
                // cria o arquivo pdf
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomedoc + ".pdf", FileMode.Create));

                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                Font.FontFamily familha = new Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                Font fonte = new Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                Font fonte1 = new Font(familha, 12, (int)System.Drawing.FontStyle.Regular);




                // abre o documento para começar a escrever o pdf
                document.Open();

                // aqui faz um for para simular diversas linhas de um relatorio
                for (int i = 0; i < 1; i++)
                {
                    // adiciona um novo paragrafo com o texto da respectiva linha.
                    document.Add(new Paragraph("DECLARAÇÃO", fonte));
                    Paragraph paragrafo1 = new Paragraph("Declaro, para os fins que se fizeram necessários, que o Sr. " 
                        + paciente+" faz acompanhamento psicológico no consultório, desde "
                        + iniT+", sob meus cuidados profissionais.", fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo1);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));
                    Paragraph paragrafo2 = new Paragraph("Nome da " + cidade + ", " + dia + "," + mes + "," + ano, fonte1);
                    paragrafo2.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo2);
                    Paragraph paragrafo3 = new Paragraph(psicologo, fonte1);
                    paragrafo3.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo3);
                    Paragraph paragrafo4 = new Paragraph(crp, fonte1);
                    paragrafo4.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo4);


                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }


            // fecha o documento
            document.Close();

            // manda abrir o pdf
            Process.Start(nomedoc + ".pdf");
        }

        private void btnCriarDesc2_Click(object sender, EventArgs e)
        {
            getInfo();


            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            try
            {
                // cria o arquivo pdf
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomedoc + ".pdf", FileMode.Create));

                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                Font.FontFamily familha = new Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                Font fonte = new Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                Font fonte1 = new Font(familha, 12, (int)System.Drawing.FontStyle.Regular);




                // abre o documento para começar a escrever o pdf
                document.Open();

                // aqui faz um for para simular diversas linhas de um relatorio
                for (int i = 0; i < 1; i++)
                {
                    // adiciona um novo paragrafo com o texto da respectiva linha.
                    document.Add(new Paragraph("DECLARAÇÃO", fonte));
                    Paragraph paragrafo1 = new Paragraph("Declaro, para fins de comprovação, que o Sr. " + paciente + 
                        ", está sendo submetido a acompanhamento psicológico, sob meus cuidados profissionais, comparecendo às sessões todas às " 
                        + diaSe +", no horário das" + horarioSe, fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo1);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));
                    Paragraph paragrafo2 = new Paragraph("Nome da " + cidade + ", " + dia + "," + mes + "," + ano, fonte1);
                    paragrafo2.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo2);
                    Paragraph paragrafo3 = new Paragraph(psicologo, fonte1);
                    paragrafo3.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo3);
                    Paragraph paragrafo4 = new Paragraph(crp, fonte1);
                    paragrafo4.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo4);


                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }


            // fecha o documento
            document.Close();

            // manda abrir o pdf
            Process.Start(nomedoc + ".pdf");
        }

        private void btnCriarRela_Click(object sender, EventArgs e)
        {
        }

        private void btnCriarRela_Click_1(object sender, EventArgs e)
        {

            getInfo();


            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            try
            {
                // cria o arquivo pdf
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomedoc + ".pdf", FileMode.Create));

                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                Font.FontFamily familha = new Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                Font fonte = new Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                Font fonte1 = new Font(familha, 12, (int)System.Drawing.FontStyle.Regular);




                // abre o documento para começar a escrever o pdf
                document.Open();

                // aqui faz um for para simular diversas linhas de um relatorio
                for (int i = 0; i < 1; i++)
                {
                    // adiciona um novo paragrafo com o texto da respectiva linha.
                    document.Add(new Paragraph("RELATÓRIO PSICOLÓGICO", fonte));
                    document.Add(new Paragraph("AUTOR/RELATOR:" + psicologo, fonte1));
                    document.Add(new Paragraph("INTERESSADO:" + interessado, fonte1));
                    document.Add(new Paragraph("ASSUNTO:" + assunto, fonte1));
                    document.Add(new Paragraph("I.    INTRODUÇÃO", fonte1));
                    Paragraph paragrafo1 = new Paragraph(introducao, fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo1);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("II.   DESCRIÇÃO", fonte1));
                    Paragraph paragrafo2 = new Paragraph(descricao, fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo2);
                    document.Add(new Paragraph("  ", fonte1));
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("III.  CONCLUSÃO", fonte1));
                    Paragraph paragrafo3 = new Paragraph(conclusao, fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo3);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));




                    Paragraph paragrafo4 = new Paragraph("Nome da " + cidade + ", " + dia + "," + mes + "," + ano, fonte1);
                    paragrafo4.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo4);
                    Paragraph paragrafo5 = new Paragraph(psicologo, fonte1);
                    paragrafo5.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo5);
                    Paragraph paragrafo6 = new Paragraph(crp, fonte1);
                    paragrafo6.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo6);


                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }


            // fecha o documento
            document.Close();

            // manda abrir o pdf
            Process.Start(nomedoc + ".pdf");
        }


        private void btnCriarPare_Click(object sender, EventArgs e)
        {
            getInfo();


            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            try
            {
                // cria o arquivo pdf
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomedoc + ".pdf", FileMode.Create));

                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                Font.FontFamily familha = new Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                Font fonte = new Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                Font fonte1 = new Font(familha, 12, (int)System.Drawing.FontStyle.Regular);




                // abre o documento para começar a escrever o pdf
                document.Open();

                // aqui faz um for para simular diversas linhas de um relatorio
                for (int i = 0; i < 1; i++)
                {
                    // adiciona um novo paragrafo com o texto da respectiva linha.
                    document.Add(new Paragraph("PARECER", fonte));
                    document.Add(new Paragraph("PARECERISTA:" + psicologo, fonte1));
                    document.Add(new Paragraph("SOLICITANTE:" + solicitantep, fonte1));
                    document.Add(new Paragraph("ASSUNTO:" + assuntop, fonte1));
                    document.Add(new Paragraph("I.    EXPOSIÇÃO DE MOTIVOS", fonte1));
                    Paragraph paragrafo1 = new Paragraph(exMotivos, fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo1);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("II.    DISCUSSÃO", fonte1));
                    Paragraph paragrafo2 = new Paragraph(discussao, fonte1);
                    paragrafo1.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo2);
                    document.Add(new Paragraph("  ", fonte1));
                    document.Add(new Paragraph("  ", fonte));
                    




                    Paragraph paragrafo4 = new Paragraph("Nome da " + cidade + ", " + dia + "," + mes + "," + ano, fonte1);
                    paragrafo4.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo4);
                    Paragraph paragrafo5 = new Paragraph(psicologo, fonte1);
                    paragrafo5.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo5);
                    Paragraph paragrafo6 = new Paragraph(crp, fonte1);
                    paragrafo6.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo6);


                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }


            // fecha o documento
            document.Close();

            // manda abrir o pdf
            Process.Start(nomedoc + ".pdf");
        }

        private void btnCriarLaudo_Click(object sender, EventArgs e)
        {

            getInfo();


            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            try
            {
                // cria o arquivo pdf
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(nomedoc + ".pdf", FileMode.Create));

                // cria um objeto do tipo FontFamily, que contem as propriedades de uma fonte
                Font.FontFamily familha = new Font.FontFamily();

                // atribui a familia da fonte, no caso Courier
                familha = iTextSharp.text.Font.FontFamily.COURIER;

                // cria uma fonte atribuindo a familha, o tamanho da fonte e o estilo (normal, negrito...)
                Font fonte = new Font(familha, 12, (int)System.Drawing.FontStyle.Bold);
                Font fonte1 = new Font(familha, 12, (int)System.Drawing.FontStyle.Regular);




                // abre o documento para começar a escrever o pdf
                document.Open();

                // aqui faz um for para simular diversas linhas de um relatorio
                for (int i = 0; i < 1; i++)
                {
                    // adiciona um novo paragrafo com o texto da respectiva linha.
                    document.Add(new Paragraph("LAUDO PSICOLÓGICO", fonte));
                    document.Add(new Paragraph("1. Identificação", fonte1));
                    document.Add(new Paragraph("Nome:" +paciente, fonte1));
                  
                    document.Add(new Paragraph("Data de nascimento:" + dtnasc + "              Idade:" + idade , fonte1));
                    
                    document.Add(new Paragraph("Estado civil:" + estCivil + "                  Natural: Basil", fonte1));
                    
                    document.Add(new Paragraph("Escolaridade:" + esco + "                    Profissão:" + profi, fonte1));
                   
                    if (respo != "")
                    {
                        document.Add(new Paragraph("Responsável:" + respo, fonte1));
                    }
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("Solicitante:" + solicitantel, fonte1));
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("Finalidade:" + finalidade, fonte1));

                  


                  
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("2. Descrição da Demanda", fonte1));
                    Paragraph paragrafo2 = new Paragraph(descricao, fonte1);
                    
                    document.Add(paragrafo2);
                    document.Add(new Paragraph("  ", fonte1));
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("3. Métodos e Técnicas", fonte1));
                    Paragraph paragrafo3 = new Paragraph(conclusao, fonte1);
                    paragrafo3.Alignment = Element.ALIGN_JUSTIFIED;
                    document.Add(paragrafo3);
                    document.Add(new Paragraph("  ", fonte));
                    document.Add(new Paragraph("  ", fonte));




                    Paragraph paragrafo4 = new Paragraph("Nome da " + cidade + ", " + dia + "," + mes + "," + ano, fonte1);
                    paragrafo4.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo4);
                    Paragraph paragrafo5 = new Paragraph(psicologo, fonte1);
                    paragrafo5.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo5);
                    Paragraph paragrafo6 = new Paragraph(crp, fonte1);
                    paragrafo6.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paragrafo6);


                }
            }
            catch (Exception de)
            {
                MessageBox.Show(de.Message);
            }


            // fecha o documento
            document.Close();

            // manda abrir o pdf
            Process.Start(nomedoc + ".pdf");
        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            pnAT1.Visible = true;
            pnAT2.Visible = false;
            pnDecla1.Visible = false;
            pnDecla2.Visible = false;
            pnRela.Visible = false;
            pnParecer.Visible = false;
            pnLaudo.Visible = false;


            pnAt1s.Visible = true;
            pnat2s.Visible = false;
            pnDec1s.Visible = false;
            pnDec2s.Visible = false;
            pnRelaS.Visible = false;
            pnParecerS.Visible = false;
            pnLaudoS.Visible = false;


        }

        private void btnaAt2_Click(object sender, System.EventArgs e)
        {
            pnAT1.Visible = false;
            pnAT2.Visible = true;
            pnDecla1.Visible = false;
            pnDecla2.Visible = false;
            pnRela.Visible = false;
            pnParecer.Visible = false;
            pnLaudo.Visible = false;



            pnAt1s.Visible = false;
            pnat2s.Visible = true;
            pnDec1s.Visible = false;
            pnDec2s.Visible = false;
            pnRelaS.Visible = false;
            pnParecerS.Visible = false;
            pnLaudoS.Visible = false;

        }

        private void btnaDecla1_Click(object sender, System.EventArgs e)
        {
            pnAT1.Visible = false;
            pnAT2.Visible = false;
            pnDecla1.Visible = true;
            pnDecla2.Visible = false;
            pnRela.Visible = false;
            pnParecer.Visible = false;
            pnLaudo.Visible = false;



            pnAt1s.Visible = false;
            pnat2s.Visible = false;
            pnDec1s.Visible = true;
            pnDec2s.Visible = false;
            pnRelaS.Visible = false;
            pnParecerS.Visible = false;
            pnLaudoS.Visible = false;

        }

        private void btnaDecla2_Click(object sender, System.EventArgs e)
        {
            pnAT1.Visible = false;           
            pnAT2.Visible = false;
            pnDecla1.Visible = false;
            pnDecla2.Visible = true;
            pnRela.Visible = false;
            pnParecer.Visible = false;
            pnLaudo.Visible = false;



            pnAt1s.Visible = false;
            pnat2s.Visible = false;
            pnDec1s.Visible = false;
            pnDec2s.Visible = true;
            pnRelaS.Visible = false;
            pnParecerS.Visible = false;
            pnLaudoS.Visible = false;


        }

        private void txtNomeD_TextChanged(object sender, System.EventArgs e)
        {
            
        }

        private void btnaRela_Click(object sender, EventArgs e)
        {
            pnAT1.Visible = false;
            pnAT2.Visible = false;
            pnDecla1.Visible = false;
            pnDecla2.Visible = false;
            pnRela.Visible = true;
            pnParecer.Visible = false;
            pnLaudo.Visible = false;



            pnAt1s.Visible = false;
            pnat2s.Visible = false;
            pnDec1s.Visible = false;
            pnDec2s.Visible = false;
            pnRelaS.Visible = true;
            pnParecerS.Visible = false;
            pnLaudoS.Visible = false;
        }

        private void pnAT2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaPare_Click(object sender, EventArgs e)
        {
            pnAT1.Visible = false;
            pnAT2.Visible = false;
            pnDecla1.Visible = false;
            pnDecla2.Visible = false;
            pnRela.Visible = false;
            pnParecer.Visible = true;
            pnLaudo.Visible = false;


            pnAt1s.Visible = false;
            pnat2s.Visible = false;
            pnDec1s.Visible = false;
            pnDec2s.Visible = false;
            pnRelaS.Visible = false;
            pnParecerS.Visible = true;
            pnLaudoS.Visible = false;
        }

        private void btnLaudo_Click(object sender, EventArgs e)
        {
            pnAT1.Visible = false;
            pnAT2.Visible = false;
            pnDecla1.Visible = false;
            pnDecla2.Visible = false;
            pnRela.Visible = false;
            pnParecer.Visible = false;
            pnLaudo.Visible = true;


            pnAt1s.Visible = false;
            pnat2s.Visible = false;
            pnDec1s.Visible = false;
            pnDec2s.Visible = false;
            pnRelaS.Visible = false;
            pnParecerS.Visible = false;
            pnLaudoS.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Funcoes.consu = "D";
            frmConCli conC = new frmConCli();
            conC.instanciaDoc = this;                       
            conC.ShowDialog();
            this.clienteTableAdapter.FillByProntu(this.psiEasy.cliente, Convert.ToInt32(Funcoes.pront));
        }

        private void frmDoc_Load(object sender, EventArgs e)
        {
          
            try
            {
                this.psicologosTableAdapter.FillByCodP(this.psiEasy.psicologos, Funcoes.codP);
               // this.clienteTableAdapter.Fill(this.psiEasy.cliente);
            }
            catch
            {
                return;
            }
            
        }

        private void pnDecla2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

       

       

        

       

        
          
        }
    }
         
       

  