using FCMontgomery.Business.Exceptions;
using FCMontgomery.Dto;
using System;

namespace FCMontgomery.Business
{
    public class ContactBusiness
    {
        public void ValidSend(ContactDto contactDto)
        {
            if (contactDto == null)
            {
                throw new BusinessException("contactDto is required");
            }

            if (string.IsNullOrEmpty(contactDto.Name))
            {
                throw new BusinessException("Name is required");
            }

            if (string.IsNullOrEmpty(contactDto.Email))
            {
                throw new BusinessException("Email is required");
            }

            if (string.IsNullOrEmpty(contactDto.Phone))
            {
                throw new BusinessException("Phone is required");
            }

            if (string.IsNullOrEmpty(contactDto.Message))
            {
                throw new BusinessException("Message is required");
            }
        }
    }
}
