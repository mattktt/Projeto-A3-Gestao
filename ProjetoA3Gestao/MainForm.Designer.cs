namespace ProjetoA3Gestao
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnCreateTicket = new Button();
            btnUpdateTicket = new Button();
            btnDeleteTicket = new Button();
            txtTitulo = new TextBox();
            txtDescricao = new TextBox();
            txtStatus = new TextBox();
            txtPrioridade = new TextBox();
            lstTickets = new ListBox();
            SuspendLayout();
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.Location = new Point(12, 226);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new Size(75, 23);
            btnCreateTicket.TabIndex = 0;
            btnCreateTicket.Text = "Create";
            btnCreateTicket.UseVisualStyleBackColor = true;
            btnCreateTicket.Click += btnCreateTicket_Click;
            // 
            // btnUpdateTicket
            // 
            btnUpdateTicket.Location = new Point(93, 226);
            btnUpdateTicket.Name = "btnUpdateTicket";
            btnUpdateTicket.Size = new Size(75, 23);
            btnUpdateTicket.TabIndex = 1;
            btnUpdateTicket.Text = "Update";
            btnUpdateTicket.UseVisualStyleBackColor = true;
            btnUpdateTicket.Click += btnUpdateTicket_Click;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(174, 226);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(75, 23);
            btnDeleteTicket.TabIndex = 2;
            btnDeleteTicket.Text = "Delete";
            btnDeleteTicket.UseVisualStyleBackColor = true;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 12);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(237, 23);
            txtTitulo.TabIndex = 3;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(12, 38);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(237, 23);
            txtDescricao.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(12, 64);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(237, 23);
            txtStatus.TabIndex = 5;
            // 
            // txtPrioridade
            // 
            txtPrioridade.Location = new Point(12, 90);
            txtPrioridade.Name = "txtPrioridade";
            txtPrioridade.Size = new Size(237, 23);
            txtPrioridade.TabIndex = 6;
            // 
            // lstTickets
            // 
            lstTickets.FormattingEnabled = true;
            lstTickets.ItemHeight = 15;
            lstTickets.Location = new Point(12, 116);
            lstTickets.Name = "lstTickets";
            lstTickets.Size = new Size(237, 94);
            lstTickets.TabIndex = 7;
            lstTickets.SelectedIndexChanged += lstTickets_SelectedIndexChanged;
            // 
            // MainForm
            // 
            ClientSize = new Size(433, 369);
            Controls.Add(lstTickets);
            Controls.Add(txtPrioridade);
            Controls.Add(txtStatus);
            Controls.Add(txtDescricao);
            Controls.Add(txtTitulo);
            Controls.Add(btnDeleteTicket);
            Controls.Add(btnUpdateTicket);
            Controls.Add(btnCreateTicket);
            Name = "MainForm";
            Text = "Ticket Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btnCreateTicket;
        private System.Windows.Forms.Button btnUpdateTicket;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPrioridade;
        private System.Windows.Forms.ListBox lstTickets;

    }
}
