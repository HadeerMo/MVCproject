using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Entites;
using Demo.PL.Helpers;
using Demo.PL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo.PL.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public EmployeeController(IUnitOfWork unitOfWork,IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index(string SearchValue)
        {
            var employees = Enumerable.Empty<Employee>();
            if (string.IsNullOrEmpty(SearchValue))
                employees = await _unitOfWork.EmployeeRepository.GetAll();
            else
                employees = _unitOfWork.EmployeeRepository.GetEmployeesByName(SearchValue);

            var mappedEmployees = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employees);
            return View(mappedEmployees);
             
        }

        public async Task<IActionResult> Create()
        {
            ViewBag.Departments = await _unitOfWork.DepartmentRepository.GetAll();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                if(employeeVM.Image != null)
                    employeeVM.ImageName = DocumentSettings.UploaderFile(employeeVM.Image, "Images");

                var mappedEmployee = _mapper.Map< EmployeeViewModel,Employee>(employeeVM);
                await _unitOfWork.EmployeeRepository.Add(mappedEmployee);
                return RedirectToAction(nameof(Index));
            }
            return View(employeeVM);
        }
        public async Task<IActionResult> Details(int? id, string viewName = "Details")
        {
            if (id == null)
                return NotFound();
            var employee = await _unitOfWork.EmployeeRepository.Get(id.Value);
            var mappedEmployee = _mapper.Map<Employee,EmployeeViewModel>(employee);
            if (employee == null)
                return NotFound();
            return View(viewName, mappedEmployee);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.Departments = await _unitOfWork.DepartmentRepository.GetAll();
            return await Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EmployeeViewModel employeeVM, [FromRoute] int? id)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            
            if (ModelState.IsValid)
            {
                try
                {
                    if (employeeVM.Image != null)
                    {
                        if (employeeVM.ImageName != null) //Update Image
                        {
                            DocumentSettings.DeleteFile(employeeVM.ImageName, "Images");
                            employeeVM.ImageName = DocumentSettings.UploaderFile(employeeVM.Image, "Images");
                        }
                        else
                        {
                            employeeVM.ImageName = DocumentSettings.UploaderFile(employeeVM.Image, "Images");
                        }

                    }


                    var mappedEmpolyee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    await _unitOfWork.EmployeeRepository.Update(mappedEmpolyee);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                    //return View(employee);
                }
            }
            return View(employeeVM);
        }

        [Authorize(Roles = "Admain")]
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int? id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();
            try
            {
                var mappedEmpolyee = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                int count = await _unitOfWork.EmployeeRepository.Delete(mappedEmpolyee);
                if (count > 0 && employeeVM.ImageName!=null)
                    DocumentSettings.DeleteFile(employeeVM.ImageName, "Images");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
        }
    }
}
