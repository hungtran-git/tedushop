using System;
using System.Collections.Generic;
using TeduShop.Common;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repository;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IPostService
    {
        ReturnMessage Add(Post post);

        ReturnMessage Update(Post post);

        ReturnMessage Delete(int postId);

        Post GetById(int postId);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByTagPaging(int page, int pageSize, out int totalRow, string tag);

        ReturnMessage Commnit(Post post);
    }

    public class PostService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;
        private IMessageService _messageService;

        public PostService(
            IPostRepository postRepository,
            IUnitOfWork unitOfWork,
            IMessageService messageService
        )
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
            this._messageService = messageService;
        }

        public ReturnMessage Add(Post post)
        {
            try
            {
                this._postRepository.Add(post);
                return this._messageService.GetSuccessReturnMessage();
            }
            catch (Exception ex)
            {
                return this._messageService.GetCustomReturnMessage(-1, ex.Message);
            }
        }

        public ReturnMessage Delete(int postId)
        {
            try
            {
                this._postRepository.Delete(postId);
                return this._messageService.GetSuccessReturnMessage();
            }
            catch (Exception ex)
            {
                return this._messageService.GetCustomReturnMessage(-1, ex.Message);
            }
        }

        public IEnumerable<Post> GetAll()
        {
            return this._postRepository.GetAll(new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(int page, int pageSize, out int totalRow, string tag)
        {
            return this._postRepository.GetMultiPaging(x => x.Status, out totalRow);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return this._postRepository.GetMultiPaging(x => x.Status, out totalRow);
        }

        public Post GetById(int postId)
        {
            return this._postRepository.GetSingleById(postId);
        }

        public ReturnMessage Commnit(Post post)
        {
            try
            {
                _unitOfWork.Commit();
                return _messageService.GetSuccessReturnMessage();
            }
            catch (Exception ex)
            {
                return _messageService.GetFailedReturnMessage();
            }
        }

        public ReturnMessage Update(Post post)
        {
            try
            {
                _postRepository.Update(post);
                return _messageService.GetSuccessReturnMessage();
            }
            catch (Exception ex)
            {
                return _messageService.GetFailedReturnMessage();
            }
        }
    }
}