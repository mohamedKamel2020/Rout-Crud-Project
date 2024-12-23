using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Demo.BLL.Interface;
using Demo.DAL.Entities;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.PL.Controllers
{
	[Authorize]
	public class DepartmentController : Controller
	{
		private readonly IDepartmentRepository _departmentRepository;
		private readonly IMapper _mapper;
        public DepartmentController(IDepartmentRepository departmentRepository,IMapper mapper)
        {
			_departmentRepository = departmentRepository;
			_mapper = mapper;
        }
		[AllowAnonymous]
        public async Task<IActionResult> Index(string SearchValue)
		{
			ViewData["Message"] = "Hello Department";
			ViewBag.Message = "Hello Department";
			IEnumerable<Department> departments = Enumerable.Empty<Department>();
			if (string.IsNullOrEmpty(SearchValue))
				departments =await _departmentRepository.GetAll();
			else
				departments = _departmentRepository.SearchEmployeeByName(SearchValue);

            var mappedDeps = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(mappedDeps);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create(DepartmentViewModel departmentVM)
		{
			if (ModelState.IsValid)
			{
				var mappedDepartment=_mapper.Map<DepartmentViewModel,Department>(departmentVM);
				await _departmentRepository.Add(mappedDepartment);
				TempData["Message"] = "Department is Created Successfully";
				return RedirectToAction(nameof(Index));
			}
			return View(departmentVM);
		}
		public async Task<IActionResult> Details(int? id,string viewName="Details")
		{
			if (id == null)
				return NotFound();
			var department =await _departmentRepository.Get(id.Value);
			if(department == null)
				return NotFound();
			var mappedDep=_mapper.Map<Department,DepartmentViewModel>(department);
			return View(viewName, mappedDep);
		}
		public async Task<IActionResult> Edit(int? id) 
		{
			return  await Details(id, "Edit");
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Edit([FromRoute]int id,DepartmentViewModel departmentVM)
		{
			if(id !=departmentVM.Id)
				return BadRequest();
			if (ModelState.IsValid)
			{
				try
				{
					var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
					await _departmentRepository.Update(mappedDepartment);
					return RedirectToAction(nameof(Index));
				}
				catch(Exception ex)
				{
					// 1.Log Exception
					// 2.Frindly Message
					ModelState.AddModelError(string.Empty, ex.Message); // 3.NotFrindly Message
                    return View(departmentVM);
                }	
			}
            return View(departmentVM);
        }
		public async Task<IActionResult> Delete(int? id) 
		{
			return await Details(id, "Delete");
		}
		[HttpPost]
		public async Task<IActionResult> Delete([FromRoute]int id,DepartmentViewModel departmentVM) 
		{
			if (id !=departmentVM.Id)
				return BadRequest();
			try
			{
                var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                await _departmentRepository.Delete(mappedDepartment);
				return RedirectToAction(nameof(Index));
			}catch(Exception ex) {
				ModelState.AddModelError(string.Empty,ex.Message);
                return View(departmentVM);
            }	
		}

	}
}
