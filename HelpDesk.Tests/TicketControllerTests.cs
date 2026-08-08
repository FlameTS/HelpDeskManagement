using HelpDesk.Api.Models;
using HelpDesk.Api.Repositories;
using Moq;

namespace HelpDesk.Tests
{
    public class TicketRepositoryTests
    {
        [Fact]
        public async Task GetAllTicketsAsync_ReturnsTickets()
        {
            // Arrange
            var mockRepository = new Mock<ITicketRepository>();

            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Title = "Printer Not Working",
                    Description = "Paper Jam",
                    Priority = "High",
                    Status = "Open",
                    RaisedBy = "Tarman"
                }
            };

            mockRepository
                .Setup(r => r.GetAllTicketsAsync())
                .ReturnsAsync(tickets);

            // Act
            var result = await mockRepository.Object.GetAllTicketsAsync();

            // Assert
            Assert.NotNull(result);
            Assert.Single(result);
            Assert.Equal("Printer Not Working", result[0].Title);
        }

        [Fact]
        public async Task GetTicketByIdAsync_ReturnsCorrectTicket()
        {
            // Arrange
            var mockRepository = new Mock<ITicketRepository>();

            var ticket = new Ticket
            {
                Id = 1,
                Title = "Printer Not Working",
                Description = "Paper Jam",
                Priority = "High",
                Status = "Open",
                RaisedBy = "Tarman"
            };

            mockRepository
                .Setup(r => r.GetTicketByIdAsync(1))
                .ReturnsAsync(ticket);

            // Act
            var result = await mockRepository.Object.GetTicketByIdAsync(1);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(1, result.Id);
            Assert.Equal("Open", result.Status);
        }

        [Fact]
        public async Task GetTicketsByStatusAsync_ReturnsFilteredTickets()
        {
            // Arrange
            var mockRepository = new Mock<ITicketRepository>();

            var tickets = new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Title = "Printer Not Working",
                    Status = "Open"
                }
            };

            mockRepository
                .Setup(r => r.GetTicketsByStatusAsync("Open"))
                .ReturnsAsync(tickets);

            // Act
            var result =
                await mockRepository.Object.GetTicketsByStatusAsync("Open");

            // Assert
            Assert.Single(result);
            Assert.Equal("Open", result[0].Status);
        }
    }
}