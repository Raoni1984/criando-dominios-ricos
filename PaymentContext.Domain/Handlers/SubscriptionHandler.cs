using System;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Repositories;
using PaymentContext.Domain.Services;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Shared.Commands;
using PaymentContext.Shared.Handlers;

namespace PaymentContext.Domain.Handlers
{
    public class SubscriptionHandler : IHandler<CreatePayPalPaymentSubscriptionCommand>
    {
        private readonly IStudentRepository _repository;
        private readonly IEmailService _emailService;

        public SubscriptionHandler(IStudentRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public ICommandResult Handle(CreatePayPalPaymentSubscriptionCommand command)
        {
            // TODO: Verificar se Documento já está cadastrado
            // if (_repository.DocumentExists(command.Document))
            //     AddNotification("Document", "Este CPF já está em uso");

            // Verificar se E-mail já está cadastrado
            // if (_repository.EmailExists(command.Email))
            //     AddNotification("Email", "Este E-mail já está em uso");

            // Gerar os VOs
            var name = new Name(command.FirstName, command.LastName);
            var document = new Document(command.Document, EDocType.CPF);
            var email = new Email(command.Email);
            var address = new Address(command.Rua,
                                      command.Numero,
                                      command.Complemento,
                                      command.Bairro,
                                      command.Cidade,
                                      command.Estado,
                                      command.Pais,
                                      command.CEP);

            // Gerar as Entidades
            var student = new Student(name, document, email, address);
            var subscription = new Subscription(DateTime.Now.AddMonths(1));
            // Só muda a implementação do Pagamento
            var payment = new PayPalPayment(
                command.TransactionCode,
                command.PaymentNumber,
                command.PaidDate,
                command.ExpireDate,
                command.Total,
                command.TotalPaid,
                command.OwnerName,
                new Document(command.Document, command.OwnerDocumentType),
                address,
                email
            );

            // Relacionamentos
            subscription.AddPayment(payment);
            student.AddSubscription(subscription);

            //TODO:  Agrupar as Validações
            //AddNotifications(name, document, email, address, student, subscription, payment);

            //Checar notificacoes
            // if(Invalid)
            // {
            //     return new CommandResult(false, "Assinatura nao realizada!");
            // }

            // Salvar as Informações
            _repository.CreateSubscription(student);

            // Enviar E-mail de boas vindas
            _emailService.Send(student.Name.ToString(), student.Email.EmailAddress, "bem vindo ao balta.io", "Sua assinatura foi criada");

            // Retornar informações
            return new CommandResult(true, "Assinatura realizada com sucesso");
        }
    }
}