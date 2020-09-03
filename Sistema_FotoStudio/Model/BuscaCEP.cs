using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_FotoStudio.Model
{
    public class BuscaCEP
    {
        private CEP cep;

        public CEP SolitarCEP(String cep)
        {

            this.cep = new CEP(cep);

            try
            {
                System.Net.HttpWebRequest requisicao = (System.Net.HttpWebRequest)System.Net.WebRequest.Create("https://viacep.com.br/ws/" + cep + "/json/");

                requisicao.AllowAutoRedirect = false;
                System.Net.HttpWebResponse ChecaServidor = (System.Net.HttpWebResponse)requisicao.GetResponse();

                if (ChecaServidor.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("Servidor indisponível");
                  
                }


                using (Stream webStream = ChecaServidor.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            response = System.Text.RegularExpressions.Regex.Replace(response, "[{},]", string.Empty);
                            response = response.Replace("\"", "");

                            String[] substrings = response.Split('\n');

                            int cont = 0;
                            foreach (var substring in substrings)
                            {
                                if (cont == 1)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    if (valor[0] == "  erro")
                                    {
                                        MessageBox.Show("CEP não encontrado");
                                     
                                    }
                                }

                                //Logradouro
                                if (cont == 2)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    this.cep.logradouro = valor[1];
                                }

                                //Bairro
                                if (cont == 4)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    this.cep.bairro = valor[1];
                                }

                                //Localidade (Cidade)
                                if (cont == 5)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    this.cep.cidade = valor[1];
                                }

                                //Estado (UF)
                                if (cont == 6)
                                {
                                    string[] valor = substring.Split(":".ToCharArray());
                                    this.cep.uf = valor[1].Trim();
                                }

                                cont++;
                            }
                        }
                    }
                }

                return this.cep;

            }
            catch (Exception erro)
            {
                //MessageBox.Show("Algo deu errado. Detalhes: " + erro.Message);
                return this.cep;
            }
        }
    }
}
