using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Private_collections.Models
{
    public class User:IdentityUser
    {
        public User()
        {
            Collections = new List<Collection>();
        }
        public List<Collection> Collections { get; set; }

    }
    
    public class Theme
    {
        public int Id { get; set; }
        public string ThemeName { get; set; }
        public string Description { get; set; }
    }
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public int CollectionId { get; set; }
    }
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Collection
    {
        public Collection()
        {
            Comments = new List<Comment>();
        }
        public List<Tag> Tags { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ThemeId { get; set; }
        public Theme Theme { get; set; }
        public int UserId { get; set; }
        public string PathMedia { get; set; }
        public DateTime DateAdded { get; set; }
        public List<Comment> Comments { get; set; }
        public string TagsString
        {
            get
            {
                var tags = Tags.Select(tg => tg.Name).ToArray();
                var res = string.Join(",", tags);
                return res;
            }
            set
            {
                var tags = value.Split(',');
                Tags = new List<Tag>();
                foreach (var tag in tags)
                    Tags.Add(new Tag { Name = tag });
            }
        }
    }
    public class Like
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CollectionId { get; set; }
    }
}
