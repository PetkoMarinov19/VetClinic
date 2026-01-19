
namespace PracticalProjectVetClinic
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Load += OnLoad;
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            listView1 = new ListView();
            imageList1 = new ImageList(components);
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Snap ITC", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(559, 63);
            label1.Name = "label1";
            label1.Size = new Size(201, 39);
            label1.TabIndex = 0;
            label1.Text = "Vet Clinic";
            label1.Click += label1_Click;
            // 
            // listView1
            // 
            listView1.LargeImageList = imageList1;
            listView1.Location = new Point(130, 169);
            listView1.Name = "listView1";
            listView1.Size = new Size(1058, 478);
            listView1.SmallImageList = imageList1;
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth16Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "85-850699_pixel-pug-pugs-puppydogpals-puppydogpalsrolly-doom-female-marine.png");
            imageList1.Images.SetKeyName(1, "127-1272239_cute-cat-black-cat-pixel-art-clipart.png");
            // 
            // button1
            // 
            button1.Font = new Font("Snap ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1027, 740);
            button1.Name = "button1";
            button1.Size = new Size(265, 50);
            button1.TabIndex = 2;
            button1.Text = "Add New Pet";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(1324, 829);
            Controls.Add(button1);
            Controls.Add(listView1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Vet Clinic";
            ResumeLayout(false);
            PerformLayout();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ImageList imageList1;
        private Button button1;
    }
}
