"use client";
import { useEffect, useState } from "react";

export default function Home() {
  const [courses, setCourses] = useState<any[]>([]);

  useEffect(() => {
    async function fetchData() {
      try {
        const response = await fetch("https://localhost:7174/api/course");
        if (response.ok) {
          const data = await response.json();
          setCourses(data);
        } else {
          console.error("Failed to fetch data");
        }
      } catch (error) {
        console.error("Error fetching data:", error);
      }
    }
    fetchData();
  }, []);

  return (
    <main className="flex min-h-screen flex-col items-center justify-between p-24">
      <h1 className="text-3xl font-bold mb-8">All Courses</h1>
      <ul className="grid grid-cols-1 gap-4">
        {courses.map((course) => (
          <li key={course.id} className="bg-gray-100 p-4 rounded">
            <h2 className="text-lg font-bold">{course.title}</h2>
          </li>
        ))}
      </ul>
    </main>
  );
}
