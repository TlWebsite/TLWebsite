// Copyright (c) Lakithu. All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace TLWebsite.Data.Utils
{
    public static class Mapper
    {
        public static MapperConfiguration Config { get; set; }

        public static void CreateConfig()
        {
            Config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<DTO.BlogComment, BlogComment>()
                        .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => src.Parent.BlogCommentID))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.BlogPost, BlogPost>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.Media, Media>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.MediaInsert, MediaInsert>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.MediaType, MediaType>();
                    cfg.CreateMap<DTO.PostTag, PostTag>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.Story, Story>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.StoryComment, StoryComment>()
                        .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => src.Parent.StoryCommentID))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.StoryPost, StoryPost>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.TextInsert, TextInsert>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.ArchivedByID));
                    cfg.CreateMap<DTO.User, User>()
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.CreatedByID))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.UpdatedByID))
                        .ForMember(dest => dest.DeactivatedBy, opt => opt.MapFrom(src => src.DeactivatedByID));
                    cfg.CreateMap<BlogComment, DTO.BlogComment>()
                        .ForMember(dest => dest.Children, opt => opt.MapFrom(src => src.BlogComment1))
                        .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => src.BlogComment2))
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<BlogPost, DTO.BlogPost>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<Media, DTO.Media>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<MediaInsert, DTO.MediaInsert>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<MediaType, DTO.MediaType>();
                    cfg.CreateMap<PostTag, DTO.PostTag>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<Story, DTO.Story>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<StoryComment, DTO.StoryComment>()
                        .ForMember(dest => dest.Children, opt => opt.MapFrom(src => src.StoryComment1))
                        .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => src.StoryComment2))
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<StoryPost, DTO.StoryPost>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<TextInsert, DTO.TextInsert>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.ArchivedBy, opt => opt.MapFrom(src => src.User2));
                    cfg.CreateMap<User, DTO.User>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.DeactivatedByID, opt => opt.MapFrom(src => src.DeactivatedBy))
                        .ForMember(dest => dest.CreatedBy, opt => opt.MapFrom(src => src.User1))
                        .ForMember(dest => dest.UpdatedBy, opt => opt.MapFrom(src => src.User11))
                        .ForMember(dest => dest.DeactivatedBy, opt => opt.MapFrom(src => src.User12));
                });
        }
    }
}
