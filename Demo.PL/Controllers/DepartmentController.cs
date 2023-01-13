using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entites;
using Demo.PL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentController(IDepartmentRepository departmentRepository
            ,IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            //ViewData["Message"] = "Hello ViewData";
            //ViewBag.Message = "Hello ViewBag";
            var departments = await _departmentRepository.GetAll();
            var mappedDepartments = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(mappedDepartments);
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
                TempData["Message"] = "Department Created Successfuly";
                var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                await _departmentRepository.Add(mappedDepartment);
                return RedirectToAction(nameof(Index));
            }
            return View(departmentVM);
        }
        public async Task<IActionResult> Details(int? id, string viewName = "Details")
        {
            if (id == null)
                return NotFound();
            var department = await _departmentRepository.Get(id.Value);
            var mappedDepartment = _mapper.Map<Department, DepartmentViewModel>(department);
            if (department == null)
                return NotFound();
            return View(viewName, mappedDepartment);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(DepartmentViewModel departmentVM, [FromRoute] int? id)
        {
            if (id != departmentVM.Id)
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
                    return BadRequest(ex.Message);
                    //return View(department);
                }
            }
            return View(departmentVM);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute]int? id,DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return BadRequest();
            try
            {
                var mappedDepartment = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                await _departmentRepository.Delete(mappedDepartment);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception )
            {
                return View(departmentVM);
            }
        }
    }
}
