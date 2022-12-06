using Google.Protobuf.Collections;
using MySqlX.XDevAPI.Common;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Corretora_de_Investimento
{
    internal class Translate
    {
        static public string language = "pt";
        static private Dictionary<string, string> textDictionaryPT =
        new Dictionary<string, string>
        {
            {"idadministrador", "ID"},
            {"idcategoria", "ID"},
            {"idemissor", "ID"},
            {"idinvestidor", "ID"},
            {"idinvestimento", "ID"},
            {"idoferta", "ID"},
            {"nome", "Nome"},
            {"senha", "Senha"},
            {"imposto", "Imposto"},
            {"fgc", "FGC"},
            {"rating", "Rating"},
            {"cnpj", "CNPJ"},
            {"cpf", "CPF"},
            {"saldoemconta", "Saldo em conta"},
            {"email", "E-mail"},
            {"datadeinvestimento", "Data de investimento"},
            {"quantidade", "Quantidade"},
            {"investidor_idinvestidor", "ID do investidor"},
            {"oferta_idoferta", "ID da oferta"},
            {"valida", "Ativa"},
            {"liquidez", "Liquidez"},
            {"aplicacaominima", "Aplicação mínima"},
            {"quantidadedisponivel", "Quantidade disponível"},
            {"rentabilidade", "Rentabilidade"},
            {"categoria_idcategoria", "ID da categoria"},
            {"emissor_idemissor", "ID do emissor"},
            {"column_name", "Nome da coluna"}
        };

        static private Dictionary<string, string> textDictionaryEN =
        new Dictionary<string, string>
        {
            {"idadministrador", "ID"},
            {"idcategoria", "ID"},
            {"idemissor", "ID"},
            {"idinvestidor", "ID"},
            {"idinvestimento", "ID"},
            {"idoferta", "ID"},
            {"nome", "Name"},
            {"senha", "Password"},
            {"imposto", "Taxes"},
            {"fgc", "FGC"},
            {"rating", "Rating"},
            {"cnpj", "CNPJ"},
            {"cpf", "CPF"},
            {"saldoemconta", "Account balance"},
            {"email", "E-mail"},
            {"datadeinvestimento", "Investiment date"},
            {"quantidade", "Amount"},
            {"investidor_idinvestidor", "Investor ID"},
            {"oferta_idoferta", "Offer ID"},
            {"valida", "Active"},
            {"liquidez", "Liquidity"},
            {"aplicacaominima", "Minimum application"},
            {"quantidadedisponivel", "Available quantity"},
            {"rentabilidade", "Profitability"},
            {"categoria_idcategoria", "Category ID"},
            {"emissor_idemissor", "Issuer ID"},
            {"column_name", "Column name"}

        };
        static public string TranslateText(string sample) {
            if (language == "pt")
            {
                string result = textDictionaryPT[sample.ToLower()];
                if (result == null)
                {
                    MessageBox.Show("Erro! Mensagem não encontrada.");
                    Application.Exit();
                    return null;
                }
                else return result;
            }
            else if (language == "en")
            {
                string result = textDictionaryEN[sample.ToLower()];
                if (result == null)
                {
                    MessageBox.Show("Error! Menssage not found.");
                    Application.Exit();
                    return null;
                }
                else return result;
            }
            else
            {
                MessageBox.Show("Erro! Linguagem não selecionada ou inválida.");
                Application.Exit();
                return null;
            }
        }
        public static void TranslateDataTable(ref DataTable sample) {
            sample.Columns.Cast<DataColumn>().ToList().ForEach(c => c.ColumnName = TranslateText(c.ColumnName));
        }
    }
}
