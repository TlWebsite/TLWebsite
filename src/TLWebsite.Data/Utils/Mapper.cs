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
                    cfg.CreateMap<DTO.Media, Media>();
                    cfg.CreateMap<DTO.MediaInsert, MediaInsert>();
                    cfg.CreateMap<DTO.MediaType, MediaType>();
                    cfg.CreateMap<DTO.PostTag, PostTag>();
                    cfg.CreateMap<DTO.Story, Story>();
                    cfg.CreateMap<DTO.StoryComment, StoryComment>();
                    cfg.CreateMap<DTO.StoryPost, StoryPost>();
                    cfg.CreateMap<DTO.TextInsert, TextInsert>();
                    cfg.CreateMap<DTO.User, User>();

                    cfg.CreateMap<BlogComment, DTO.BlogComment>()
                        .ForMember(dest => dest.Parent, opt => opt.MapFrom(src => src.BlogComment2))
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy));
                    cfg.CreateMap<BlogPost, DTO.BlogPost>()
                        .ForMember(dest => dest.CreatedByID, opt => opt.MapFrom(src => src.CreatedBy))
                        .ForMember(dest => dest.UpdatedByID, opt => opt.MapFrom(src => src.UpdatedBy))
                        .ForMember(dest => dest.ArchivedByID, opt => opt.MapFrom(src => src.ArchivedBy));
                    cfg.CreateMap<Media, DTO.Media>();
                    cfg.CreateMap<MediaInsert, DTO.MediaInsert>();
                    cfg.CreateMap<MediaType, DTO.MediaType>();
                    cfg.CreateMap<PostTag, DTO.PostTag>();
                    cfg.CreateMap<Story, DTO.Story>();
                    cfg.CreateMap<StoryComment, DTO.StoryComment>();
                    cfg.CreateMap<StoryPost, DTO.StoryPost>();
                    cfg.CreateMap<TextInsert, DTO.TextInsert>();
                    cfg.CreateMap<User, DTO.User>();
                });
        }
    }
}
