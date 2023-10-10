﻿using eagles_food_backend.Domains.DTOs;
using eagles_food_backend.Domains.Models;

namespace eagles_food_backend.Services.UserServices
{
    public interface IUserRepository
    {
        Task<Response<Dictionary<string, string>>> CreateUser(CreateUserDTO user);
        Task<Response<Dictionary<string, string>>> Login(UserLoginDTO user);
        Task<Response<UserProfileReadDTO>> GetUserProfile(int id);
        Task<Response<UserBankUpdateDTO>> UpdateUserBank(UserBankUpdateDTO userbank, int user_id);
        Task<Response<UserReadAllDTO>> GetAllUsersByOrganization(int user_id);
        Task<Response<UserReadDTO>> SearchForUser(string email);
        Task<Response<bool>> UploadPhoto(IFormFile photo, int id);
        Task<Response<Dictionary<string, string>>> ChangePassword(ChangePasswordDTO model);
        Task<Response<UserReadDTO>> ForgotUserPassword(string email);
        Task<Response<UserReadDTO>> ResetUserPassword(ResetPasswordDTO resetDto);
        Task<Response<List<OrganizationInviteDTO>>> UserInvites(int userId);
        Task<Response<bool>> ToggleInvite(int userId, ToggleInviteDTO model);
        Task<Response<UserReadDTO>> VerifyResetToken(string email, string code);
        Task<Response<bool>> SendInvitationRequest(int userId, int orgId);
        Task<Response<UserDTO>> UpdateUserProfile(int userId, UpdateUserDTO model);
    }
}