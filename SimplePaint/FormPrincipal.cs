using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePaint
{
    public partial class FormPrincipal : Form
    {
        private bool flagPintar = false; // controlar quando se deve pintar
        private Graphics graphicsPainelPintura;
        private float espessuraCaneta;
        private Color corBorracha;
        private bool flagApagar = false; // controlar quando se deve apagar
        private Image imagemASalvar;
        private Graphics graphicsImagemASalvar;

        public FormPrincipal()
        {
            InitializeComponent();

            buttonBorracha.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray; //altera a cor do botao quando o curso esta sobre ele
            buttonLimpar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;
            buttonSalvar.FlatAppearance.MouseOverBackColor = Color.DarkSlateGray;

            for (int i = 2; i <= 100; i += 2)
            {
                comboBoxEspessuraDaCaneta.Items.Add(i);
            }
            comboBoxEspessuraDaCaneta.Text = "10";
            comboBoxEspessuraDaCaneta.IntegralHeight = false; // necessario para definir numero de items
            comboBoxEspessuraDaCaneta.MaxDropDownItems = 4; // define numero de itens

            graphicsPainelPintura = panelPintura.CreateGraphics(); // graphics permite pintura 
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.Text);
            corBorracha = panelPintura.BackColor;

            imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //imagem para salvar
            graphicsImagemASalvar = Graphics.FromImage(imagemASalvar); // extraindo graphics da imagem para salvar de forma a poder desenhar 
            graphicsImagemASalvar.Clear(panelPintura.BackColor);
        }

        private void buttonCorCaneta_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog(); // caixa de seleçao de cores
            var corDeEscolha = colorDialog.ShowDialog(); // exibe forma modal
            if (corDeEscolha == DialogResult.OK)
            {
                buttonCorCaneta.BackColor = colorDialog.Color;
            }
        }

        private void panelPintura_MouseDown(object sender, MouseEventArgs e)
        {
            flagPintar = true;
        }

        private void panelPintura_MouseUp(object sender, MouseEventArgs e)
        {
            flagPintar = false;
        }

        private void panelPintura_MouseMove(object sender, MouseEventArgs e)
        {
            if (flagPintar)
            {
                if (!flagApagar)
                {
                    // desenhamos uma elipse 
                    graphicsPainelPintura
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                    // desenhando imagem para salvar
                    graphicsImagemASalvar
                        .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
                else
                {
                    graphicsPainelPintura
                        .DrawRectangle(new Pen(corBorracha, espessuraCaneta), new Rectangle(e.X, e.Y, (int)espessuraCaneta, (int)espessuraCaneta));
                    graphicsImagemASalvar
                      .DrawEllipse(new Pen(buttonCorCaneta.BackColor, espessuraCaneta), new RectangleF(e.X, e.Y, espessuraCaneta, espessuraCaneta));
                }
            }
        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você tem certeza? Todo o desenho será apagado!", "Apagar desenho", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                imagemASalvar = new Bitmap(panelPintura.Width, panelPintura.Height); //imagem para salvar
                graphicsImagemASalvar = Graphics.FromImage(imagemASalvar);
                graphicsPainelPintura.Clear(Color.White);
            }
        }

        private void comboBoxEspessuraDaCaneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            espessuraCaneta = float.Parse(comboBoxEspessuraDaCaneta.SelectedItem.ToString());
        }

        private void buttonBorracha_MouseDown(object sender, MouseEventArgs e) //se clicar com o botao direito do mouse sob o botao da borracha
        {
            if (e.Button == MouseButtons.Right)
            {
                var colorDialog = new ColorDialog();
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    corBorracha = colorDialog.Color; // seleciona a cor da borracha de acordo com a escolha do usuario
                }
            }
            else
            {
                if (!flagApagar)
                {
                    flagApagar = true;
                    buttonBorracha.BackColor = corBorracha;
                }
                else
                {
                    flagApagar = false;
                    buttonBorracha.BackColor = Color.Black;
                }
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog(); // janela para salvar arquivos
            saveFileDialog.Filter = "Portable Network Graphics|.png|ArquivoJPEG|.jpeg"; // atribuindo extensoes possiveis
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // definindo a extensao da imagem que iremos salvar
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Png);
                        break;
                    case 2:
                        imagemASalvar.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        // evento disparado sempre que o painel é redimensionado
        private void panelPintura_Resize(object sender, EventArgs e)
        {
            graphicsPainelPintura = panelPintura.CreateGraphics(); // atualiza a referencia do objeto graphics do painel
            var imagemTemporaria = new Bitmap(panelPintura.Width, panelPintura.Height); // cria imagem temporaria
            var graphicsImagemTemporaria = Graphics.FromImage(imagemTemporaria); 
            graphicsImagemTemporaria.DrawImage(imagemASalvar, 0, 0); // desenhamnos a imagem antiga na imagem temporaria
            imagemASalvar = imagemTemporaria;
            graphicsImagemASalvar = graphicsImagemTemporaria;
        }
    }
}
