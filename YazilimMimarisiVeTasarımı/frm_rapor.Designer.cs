
namespace YazilimMimarisiVeTasarımı
{
    partial class frm_rapor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_html = new System.Windows.Forms.Button();
            this.btn_xml = new System.Windows.Forms.Button();
            this.btn_json = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_html
            // 
            this.btn_html.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_html.Location = new System.Drawing.Point(34, 12);
            this.btn_html.Name = "btn_html";
            this.btn_html.Size = new System.Drawing.Size(110, 60);
            this.btn_html.TabIndex = 0;
            this.btn_html.Text = "HTML";
            this.btn_html.UseVisualStyleBackColor = true;
            this.btn_html.Click += new System.EventHandler(this.btn_html_Click);
            // 
            // btn_xml
            // 
            this.btn_xml.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_xml.Location = new System.Drawing.Point(34, 91);
            this.btn_xml.Name = "btn_xml";
            this.btn_xml.Size = new System.Drawing.Size(110, 60);
            this.btn_xml.TabIndex = 0;
            this.btn_xml.Text = "XML";
            this.btn_xml.UseVisualStyleBackColor = true;
            this.btn_xml.Click += new System.EventHandler(this.btn_xml_Click);
            // 
            // btn_json
            // 
            this.btn_json.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_json.Location = new System.Drawing.Point(34, 170);
            this.btn_json.Name = "btn_json";
            this.btn_json.Size = new System.Drawing.Size(110, 60);
            this.btn_json.TabIndex = 0;
            this.btn_json.Text = "JSON";
            this.btn_json.UseVisualStyleBackColor = true;
            this.btn_json.Click += new System.EventHandler(this.btn_json_Click);
            // 
            // frm_rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(183, 263);
            this.Controls.Add(this.btn_json);
            this.Controls.Add(this.btn_xml);
            this.Controls.Add(this.btn_html);
            this.Name = "frm_rapor";
            this.Text = "frm_rapor";
            this.Load += new System.EventHandler(this.frm_rapor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_html;
        private System.Windows.Forms.Button btn_xml;
        private System.Windows.Forms.Button btn_json;
    }
}