using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace VP_Asgn4.Controllers
{
    class Validations
    {
        ErrorProvider EP;

        public Validations()
        {
            EP = new ErrorProvider();
        }

        public void thisFieldIsRequired(Control InputField, Control SubmitBtn)
        {
            if (InputField.Text == "")
            {
                EP.SetError(InputField, "This field is required.");
                SubmitBtn.Enabled = false;
            }
            else
            {
                EP.Clear();
                SubmitBtn.Enabled = true;
            }
        
        }

        public void validateDirectory(String dir)
        {
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }
        }
    }
}
