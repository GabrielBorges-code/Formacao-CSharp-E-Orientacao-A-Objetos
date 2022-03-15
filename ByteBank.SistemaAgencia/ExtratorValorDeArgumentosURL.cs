using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ExtratorValorDeArgumentosURL
    {
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {
            //string.IsNullOrEmpty(url);

            if (url == null || url == "")
            {
                throw new ArgumentNullException(nameof(url));
            }

            URL = url;


        }

    }
}
