using RestaurantManagement.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RestaurantManagement.Domain.Entities
{
    public class User : BaseEntity
    {
        private string firstName = null!;
        private string lastName = null!;
        private RoleType role;
        private bool isActive;

        private byte[] passwordHash = Array.Empty<byte>();
        private byte[] passwordSalt = Array.Empty<byte>();

        public byte[] PasswordHash => passwordHash;
        public byte[] PasswordSalt => passwordSalt;

        public string FirstName
        {
            get => firstName;
            set => SetProperty(ref firstName, value);
        }

        public string LastName
        {
            get => lastName;
            set => SetProperty(ref lastName, value);
        }

        public RoleType Role
        {
            get => role;
            set => SetProperty(ref role, value);
        }

        public bool IsActive
        {
            get => isActive;
            set => SetProperty(ref isActive, value);
        }

        public void SetPassword(string password)
        {
            using var hmac = new HMACSHA256();
            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            OnPropertyChanged(nameof(PasswordHash));
            OnPropertyChanged(nameof(PasswordSalt));
        }

        public bool VerifyPassword(string password)
        {
            using var hmac = new HMACSHA256(passwordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(passwordHash);
        }
    }
}
