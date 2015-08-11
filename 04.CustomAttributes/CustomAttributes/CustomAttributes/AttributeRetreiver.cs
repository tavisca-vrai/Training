using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections;
using Attributes;


namespace CustomAttributes
{
    public class AttributeRetreiver
    {
        public List<string> SelectTestMethods(string dllPath)
        {
            List<string> methodList = new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                foreach (Type type in assembly.GetTypes())
                {
                    if (ClassAttributes.Exists(type))
                    {
                        string className = type.FullName;

                        foreach (MethodInfo methodInfo in type.GetMethods())
                        {
                            foreach (Attribute customAttribute in methodInfo.GetCustomAttributes(false))
                            {
                                MethodAttribute testMethodAttribute = customAttribute as MethodAttribute;
                                if (null != testMethodAttribute)
                                {
                                    methodList.Add(className + "." + methodInfo.Name);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message, e);
            }
            return methodList;
        }

        public List<string> SelectTestMethodCategory(string dllPath, string category)
        {
            List<string> methodList = new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                foreach (Type type in assembly.GetTypes())
                {
                    if (ClassAttributes.Exists(type))
                    {
                        string className = type.FullName;

                        foreach (MethodInfo methodInfo in type.GetMethods())
                        {
                            foreach (Attribute customAttribute in methodInfo.GetCustomAttributes(false))
                            {
                                AttributeCategory testCategoryAttribute = customAttribute as AttributeCategory;
                                if (null != testCategoryAttribute)
                                {
                                    if (string.Equals(testCategoryAttribute.Category, category, StringComparison.OrdinalIgnoreCase))
                                        methodList.Add(className + "." + methodInfo.Name);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message, e);
            }
            return methodList;
        }


        public List<string> SelectIgnoreMethods(string dllPath)
        {
            List<string> methodList = new List<string>();
            try
            {
                Assembly assembly = Assembly.LoadFrom(dllPath);
                foreach (Type type in assembly.GetTypes())
                {
                    if (ClassAttributes.Exists(type))
                    {
                        string className = type.FullName;

                        foreach (MethodInfo methodInfo in type.GetMethods())
                        {
                            foreach (Attribute customAttribute in methodInfo.GetCustomAttributes(false))
                            {
                                Ignore testCategoryAttribute = customAttribute as Ignore;
                                if (null != testCategoryAttribute)
                                {
                                    methodList.Add(className + "." + methodInfo.Name);
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception e)
            {
                throw new System.Exception(e.Message, e);
            }
            return methodList;
        }
    }
}