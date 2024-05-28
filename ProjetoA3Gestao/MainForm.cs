using ProjetoA3Gestao.Controller;
using ProjetoA3Gestao.Model;

namespace ProjetoA3Gestao
{
    public partial class MainForm : Form
    {
        private TicketFactory _ticketFactory = new ConcreteTicketFactory();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCreateTicket_Click(object sender, EventArgs e)
        {
            var ticket = _ticketFactory.CreateTicket();
            ticket.Titulo = txtTitulo.Text;
            ticket.Descricao = txtDescricao.Text;
            ticket.Status = txtStatus.Text;
            ticket.Prioridade = txtPrioridade.Text;

            var createCommand = new CreateTicketCommand(ticket);
            createCommand.Execute();

            RefreshTicketList();
        }

        private void btnUpdateTicket_Click(object sender, EventArgs e)
        {
            var ticket = (Ticket)lstTickets.SelectedItem;
            if (ticket != null)
            {
                ticket.Titulo = txtTitulo.Text;
                ticket.Descricao = txtDescricao.Text;
                ticket.Status = txtStatus.Text;
                ticket.Prioridade = txtPrioridade.Text;

                var updateCommand = new UpdateTicketCommand(ticket);
                updateCommand.Execute();

                RefreshTicketList();
            }
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            var ticket = (Ticket)lstTickets.SelectedItem;
            if (ticket != null)
            {
                var deleteCommand = new DeleteTicketCommand(ticket);
                deleteCommand.Execute();

                RefreshTicketList();
            }
        }

        private void RefreshTicketList()
        {
            lstTickets.DataSource = null;
            lstTickets.DataSource = TicketRepository.Instance.GetTickets();
            lstTickets.DisplayMember = "Titulo";
        }

        private void lstTickets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ticket = (Ticket)lstTickets.SelectedItem;
            if (ticket != null)
            {
                txtTitulo.Text = ticket.Titulo;
                txtDescricao.Text = ticket.Descricao;
                txtStatus.Text = ticket.Status;
                txtPrioridade.Text = ticket.Prioridade;
            }
        }
    }
}
