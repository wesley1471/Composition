using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio.Entities
{
    internal class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post()
        {
        }
        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }
        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sd = new StringBuilder();
            sd.AppendLine(Title);
            sd.Append(Likes);
            sd.Append(" likes  = ");
            sd.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sd.AppendLine(Content);
            sd.AppendLine("Comments: ");
            foreach (Comment comment in Comments)
            {
                sd.AppendLine(comment.Text);
            }
            return sd.ToString();
        }
    }
}
