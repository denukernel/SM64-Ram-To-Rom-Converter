namespace SM64_RAM_Address_to_ROM_Address_converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string input = txtRamAddress.Text.Trim();
            
            // Remove 0x prefix if present
            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                input = input.Substring(2);
            }

            if (uint.TryParse(input, System.Globalization.NumberStyles.HexNumber, null, out uint ramAddress))
            {
                bool success = AddressConverter.TryConvert(ramAddress, out uint romAddress, out string info);
                
                lblDescriptionValue.Text = info;

                if (success)
                {
                    txtRomAddress.Text = AddressConverter.FormatAddress(romAddress);
                }
                else
                {
                    // Check if it was a known region but failed due to RAM-only or just not found
                    if (!string.IsNullOrEmpty(info) && info != "Unknown") 
                    {
                         txtRomAddress.Text = "N/A (RAM Only)";
                    }
                    else
                    {
                         txtRomAddress.Text = "Not Found";
                         lblDescriptionValue.Text = "Address not in known standard regions.";
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid hexadecimal address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
