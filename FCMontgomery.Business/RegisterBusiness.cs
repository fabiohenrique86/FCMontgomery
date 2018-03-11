using FCMontgomery.Business.Exceptions;
using FCMontgomery.Dto;
using System;

namespace FCMontgomery.Business
{
    public class RegisterBusiness
    {
        public void ValidRegister(RegisterDto registerDto)
        {
            if (registerDto == null)
            {
                throw new BusinessException("registerDto is required");
            }

            if (string.IsNullOrEmpty(registerDto.Name))
            {
                throw new BusinessException("Name is required");
            }

            if (string.IsNullOrEmpty(registerDto.Email))
            {
                throw new BusinessException("Email is required");
            }

            if (string.IsNullOrEmpty(registerDto.Category))
            {
                throw new BusinessException("Category is required");
            }

            if (string.IsNullOrEmpty(registerDto.Phone))
            {
                throw new BusinessException("Phone is required");
            }

            if (string.IsNullOrEmpty(registerDto.Address))
            {
                throw new BusinessException("Address is required");
            }

            if (string.IsNullOrEmpty(registerDto.City))
            {
                throw new BusinessException("City is required");
            }

            if (string.IsNullOrEmpty(registerDto.BirthDay))
            {
                throw new BusinessException("BirthDay is required");
            }

            if (string.IsNullOrEmpty(registerDto.Gender))
            {
                throw new BusinessException("Gender is required");
            }

            if (string.IsNullOrEmpty(registerDto.ParentName))
            {
                throw new BusinessException("Parent's Name is required");
            }

            if (string.IsNullOrEmpty(registerDto.ParentPhone))
            {
                throw new BusinessException("Parent's Phone is required");
            }

            if (string.IsNullOrEmpty(registerDto.ParentEmail))
            {
                throw new BusinessException("Parent's Email is required");
            }

            if (string.IsNullOrEmpty(registerDto.Position))
            {
                throw new BusinessException("Position is required");
            }

            if (string.IsNullOrEmpty(registerDto.ClubExperience))
            {
                throw new BusinessException("ClubExperience is required");
            }

            if (string.IsNullOrEmpty(registerDto.YearExperience))
            {
                throw new BusinessException("YearExperience is required");
            }
        }
    }
}
