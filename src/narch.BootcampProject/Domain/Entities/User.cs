﻿namespace Domain.Entities;

public class User : NArchitecture.Core.Security.Entities.User<Guid>
{
    //test
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }

    public User()
    {
        UserOperationClaims = new HashSet<UserOperationClaim>();
        RefreshTokens = new HashSet<RefreshToken>();
        OtpAuthenticators = new HashSet<OtpAuthenticator>();
        EmailAuthenticators = new HashSet<EmailAuthenticator>();
    }

    public User(
        Guid id,
        string userName,
        string firstName,
        string lastName,
        DateTime dateOfBirth,
        string email,
        byte[] passwordHash,
        byte[] passwordSalt
    )
        : this()
    {
        Id = id;
        UserName = userName;
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        Email = email;
        PasswordHash = passwordHash;
        PasswordSalt = passwordSalt;
    }

    public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; } = default!;
    public virtual ICollection<RefreshToken> RefreshTokens { get; set; } = default!;
    public virtual ICollection<OtpAuthenticator> OtpAuthenticators { get; set; } = default!;
    public virtual ICollection<EmailAuthenticator> EmailAuthenticators { get; set; } = default!;
}
