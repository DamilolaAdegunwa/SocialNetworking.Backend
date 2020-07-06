﻿using Core.Service.Requests;
using Domain.ViewModels.Post;

namespace Service.Mediator.V1.PostCase.Crud.Validations
{
    public class RemoverPostValidator : PostValidator<RemoverRequest<PostRequest, PostResponse>>
    {
    }
}
