import Link from 'next/link';
import React from 'react';
import { courses } from '@/app/data/courses';

function nth(n: number) {
  return ['st', 'nd', 'rd'][((((n + 90) % 100) - 10) % 10) - 1] || 'th';
}

const DashboardPage = () => {
  return (
    <div className="flex w-full justify-center mt-4">
      <div className="flex flex-wrap w-[1000px]">
        {courses.map((course) => {
          return (
            <div
              className="flex flex-col justify-evenly w-56 h-56 p-6 mx-3 mb-3
            bg-green-600 rounded-lg 
            border border-grey-200 shadow-md"
              key={course.id}
            >
              <div>
                <h3>
                  {course.period}
                  <sup>{nth(course.period)}</sup> Period
                </h3>
                <h3>{course.courseName}</h3>
              </div>

              <div>
                <Link
                  href={{
                    pathname: `/gradebook/${course.id}`,
                    // query: { name: 'test' },
                  }}
                >
                  Gradebook
                </Link>
              </div>
              <div>
                <Link
                  href={{
                    pathname: `/attendance/${course.id}`,
                    // query: { name: 'test' },
                  }}
                >
                  Attendance
                </Link>
              </div>
            </div>
          );
        })}
      </div>
    </div>
  );
};

export default DashboardPage;
