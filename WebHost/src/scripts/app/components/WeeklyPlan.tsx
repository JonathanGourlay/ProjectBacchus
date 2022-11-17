import React, { useState } from "react";

export const WeeklyPlan: React.FC = () => {
    const days = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];
    const meals = ["Breakfast", "Lunch", "Dinner", "Snack"]

    return (
        <>
            <div className="overflow-x-auto">
                <table className="table table-zebra w-full">
                    <thead>
                        <tr>
                            <th></th>
                            <>
                                {days.map((day, i) => {
                                    {/* <!-- head --> */ }
                                    return (
                                        <th>{day}</th>
                                    )
                                })}
                            </>
                        </tr>
                    </thead>
                    <tbody>
                        <>
                            {meals.map((meal, i) => {
                                {/* <!-- row --> */ }
                                return (
                                    <tr>
                                        <th>{meal}</th>

                                        {days.map((day, i) => {
                                            {/* <!-- head --> */ }
                                            return (
                                                <th>{meal} {i}</th>
                                            )
                                        })}
                                    </tr>
                                )
                            })}
                        </>
                    </tbody>
                </table>
            </div>
        </>
    );
};
