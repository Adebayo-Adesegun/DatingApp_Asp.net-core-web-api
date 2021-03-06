﻿using AutoMapper;
using DatingApp.Core.DTOs;
using DatingApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, UserForListDTO>()
                .ForMember(dest => dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                })
                .ForMember(dest => dest.Age, opt =>
                {
                    opt.MapFrom(d => d.DateOfBirth.CalculateAge());
                });
            CreateMap<User, UserForDetailDTO>()
                 .ForMember(dest => dest.PhotoUrl, opt =>
                 {
                     opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.IsMain).Url);
                 })
                 .ForMember(dest => dest.Age, opt =>
                 {
                     opt.MapFrom(d => d.DateOfBirth.CalculateAge());
                 });
            CreateMap<Photo, PhotosForDetailDTO>();
            CreateMap<UserForUpdateDto, User>();
            CreateMap<Photo, PhotoForReturnDto>();
            CreateMap<PhotoForCreationDTO, Photo>();
            CreateMap<UserForRegisterDTO,User>();
            CreateMap<MessageForCreationDto, Message>().ReverseMap();

            CreateMap<Message, MessageToReturnDto>()
                .ForMember(m => m.SenderPhotoUrl, opt => 
                        opt.MapFrom(u => u.Sender.Photos.FirstOrDefault(p => p.IsMain).Url))
                .ForMember(m => m.RecipientPhotoUrl, opt => 
                        opt.MapFrom(u => u.Recipient.Photos.FirstOrDefault(p => p.IsMain).Url));
        }
    }
}
