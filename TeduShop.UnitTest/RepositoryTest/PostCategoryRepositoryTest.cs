using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Reponsitories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest
{
    [TestClass]
    public class PostCategoryRepositoryTest
    {
        IDbFactory _dbFactory;
        IUnitOfWork _unitOfWork;
        IPostCategoryRepository _objRepository;

        [TestInitialize]
        public void Initialize()
        {
            _dbFactory = new DbFactory();
            _objRepository = new PostCategoryRepository(_dbFactory);
            _unitOfWork = new UnitOfWork(_dbFactory);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();

            category.Name = "Test Category";
            category.Alias = "Test_category";
            category.Status = true;

            var result = _objRepository.Add(category);

            _unitOfWork.Commit();

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            List<PostCategory> list = _objRepository.GetAll().ToList();
            Assert.AreEqual(3,list.Count);
        }


        [TestMethod]
        public void PostCategory_Reponsitory_Sothing()
        {
            PostCategory item = _objRepository.GetSingleById(1);
            Assert.IsNotNull(item);
        }
    }
}
