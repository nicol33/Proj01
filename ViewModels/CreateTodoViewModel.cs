using System.ComponentModel.DataAnnotations;

namespace Proj01.ViewModels
{
    public class CreateTodoViewModel
    {
        [Required]
        public required string Title { get; set; }
    }
}
