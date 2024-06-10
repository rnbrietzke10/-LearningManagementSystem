import React from 'react';
import { courses } from '../data/courses';
import { students } from '../data/students';
import { assignments } from '../data/assignments';

const Gradebook = () => {
  const { results } = students;

  type Course = {
    id: number;
    period: number;
    courseName: string;
    students: number[];
    numStudents: number;
    duration: number;
  };
  const course: Course = courses.find(obj => obj.id === 5)!;
  let count = 0;
  return (
    <>
      <div className='w-full m-5'>
        <h3>Course Name: {course?.courseName}</h3>
        <span>Period: {course?.period}</span>
      </div>

      <div className='flex'>
        <div className='mt-5 flex flex-col basis-1/4'>
          <div className='flex  justify-between border-b'>
            <span className='ps-16 w-60 text-sm'>Name</span>
            <div className='flex basis-1/2 justify-between  pr-4'>
              <span className='text-sm'>Id</span>
              <span className='text-sm'>Age</span>
              <span className='text-sm'>Grade </span>
              <span className='text-sm'>Avg</span>
            </div>
          </div>
          <div className='flex  flex-col'>
            {results.map((student, idx) => {
              if (course?.students.includes(student.id)) {
                count++;
                return (
                  <div
                    className={`border-b pb-2 pr-5 flex justify-between ${
                      (idx + 1) % 2 === 0 ? 'bg-slate-300' : ''
                    }`}
                  >
                    <div className='flex justify-between basis-1/2 '>
                      <span className='text-sm  mt-5 ms-5 mr-5'>{count}</span>
                      <span className='text-sm  mt-5 w-40'>
                        {student.lastName}, {student.firstName}
                      </span>
                    </div>
                    <div className=' flex justify-between basis-1/2'>
                      <span className='text-sm  mt-5'>{student.id}</span>
                      <span className='text-sm  mt-5'>{student.age}</span>
                      <span className='text-sm  mt-5'>
                        {student.gradeLevel}
                      </span>
                      <span className='text-sm  mt-5'>{student.average}</span>
                    </div>
                  </div>
                );
              }
            })}
          </div>
        </div>
        <div className='basis-3/4'>
          <div></div>
        </div>
      </div>
    </>
  );
};

export default Gradebook;
