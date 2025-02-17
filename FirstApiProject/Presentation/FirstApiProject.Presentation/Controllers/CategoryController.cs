using FirstApiProject.Application.Repository;
using FirstApiProject.Domain.Entites.Concretes;
using FirstApiProject.Presentation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace FirstApiProject.Presentation.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController(ICategoryRepository categoryRepository) : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository=categoryRepository;


     [HttpGet(Name ="GetCategoryList")]
     public ActionResult<ResponseModel<IEnumerable<Category>>>GetAll()
     {
        var categories= _categoryRepository.GetAll();
        if(!categories.Any())
        {
            return NotFound(
             new ResponseModel<IEnumerable<Category>>
            {
                Success=false,
                Message="Not found Categories",
                Data=null
            });
        }
        return Ok(new ResponseModel<IEnumerable<Category>>
        { 
            Success = true,
            Message="Categories retrived successfull!",
            Data=categories
        });

     }

     [HttpPost(Name ="AddCategory")]
     public async Task<ActionResult<ResponseModel<Category>>>AddCategory([FromBody]Category category)
    {
        if(category is null)
        {
            return BadRequest(new ResponseModel<Category> {Success=false,Message="Categories is null",Data=category });
        }
        
            await _categoryRepository.AddAsync(category);
            return Ok(new ResponseModel<Category> { Success=true, Message="Category added successfully", Data=category });
       
       
    }


    [HttpPut("{id}", Name="UpdateCategory")]
    public async Task<ActionResult<ResponseModel<Category>>> UpdateCategory(int id, [FromBody] Category category)
    {
        if(category is null)
        {
            return BadRequest(new ResponseModel<Category> { Success=false, Message="Category is null", Data=null });
        }
        else if (category.Id!=id)
        {
            return BadRequest(new ResponseModel<Category> { Success=false, Message="Category does not match with id", Data=null });
        }
        var update = await _categoryRepository.UpdateAsync(category);
        if(!update)
        {
            return NotFound(new ResponseModel<Category> { Success=false, Message="Category dont found", Data=null });
        }
        else
        {
            return Ok(new ResponseModel<Category> { Success=true, Message="Category update successfully", Data=category });
        }
        
    }

    [HttpDelete("{id}",Name ="DelateCategory")]
    public  ActionResult<ResponseModel<Category>> DeleteCategory(int id)
    {
        if(id <0)
        return BadRequest(new ResponseModel<Category> { Success=false, Message="id is invalid", Data=null });

        var category=_categoryRepository.GetAll().FirstOrDefault(e=>e.Id==id);
        if(category is null)
            return BadRequest(new ResponseModel<Category> { Success=false, Message="Category is null", Data=null });
        var delete = _categoryRepository.Delete(category);
        return Ok(new ResponseModel<Category> { Success=true, Message="Category deleted successfully", Data=category });


    }



}
