﻿using ArticleManager.Commands.CreateArticle;
using FluentValidation;
using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArticleCategoryManager.Commands.CreateArticle
{
    public class CreateArticleCommandValidator : AbstractValidator<CreateArticleCommand>
    {
        public CreateArticleCommandValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.CategoryId).NotEqual(0);
            RuleFor(x => x.Title).Length(1,10);
        }
    }
}
