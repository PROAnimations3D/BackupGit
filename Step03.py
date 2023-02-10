import os
import re

# define the path to search for .cs files
path = r"C:\CUTE\1.80c\1.80c\Assets\UnityMultiplayerARPG"

# initialize a list to store the method names and their corresponding file names
methods = set()

# list of keywords to skip insertion
keywords_to_skip = ["interface IStateInfo", "public void Run()"]

# list of files to skip
files_to_skip = ["ContinuationQueue.cs", "PlayerLoopRunner.cs", "PlayerLoopHelper.cs", "UIMmoCentralAckLoading.cs", "DefaultLagCompensationManager.cs", "DefaultInterestManager.cs", "DevExtUtils.cs"]

# 1) Define the first process
def process_methods(path):
    # iterate through the files and subdirectories
    for root, dirs, files in os.walk(path):
        for file in files:
            if file.endswith(".cs"):
                if file in files_to_skip:
                    continue
                file_path = os.path.join(root, file)
                with open(file_path, 'r') as f:
                    print(f"Reading file {file_path}")
                    content = f.read()
                    # use regular expression to extract method names
                    method_declarations = re.findall(r'(?m)^\s*(public|private|protected)\s+(static\s+)?(\w+)\s+(\w+)\s*\([^\)]*\)\s*(\{|;)', content)
                    for method_declaration in method_declarations:
                        method_tuple = (method_declaration[3], file_path)
                        if method_tuple not in methods:
                            methods.add(method_tuple)

# 2) Define the second process
def update_methods(methods):
    # update the methods in the .cs files and print the results to the console
    method_count = 0
    for method_name, file_path in methods:
        file_name = os.path.basename(file_path)
        if file_name in files_to_skip:
            continue
        file_directory = file_path.split('\\')
        file_directory = file_directory[:-1]
        file_directory = "_".join(file_directory[file_directory.index("Assets") + 1:]).replace('\\', '/')
        with open(file_path, 'r') as file:
            content = file.read()
        match = re.search(r'(?m)^\s*(public|private|protected)\s+(static\s+)?(\w+)\s+' + method_name + r'\s*\([^\)]*\)\s*(\{|;)', content)
        if match:
            if "interface IStateInfo" in content[:match.start(0)] or "public void Run()" in content[:match.start(0)]:
                continue
            method_count_for_file = 0
            method_log_search = re.search(r'UnityEngine.Debug.Log\("\[' + file_directory + '_' + method_name + ',Step-[0-9]+\]"\)', content)
            while method_log_search:
                method_count_for_file += 1
                method_log_search = re.search(r'UnityEngine.Debug.Log\("\[' + file_directory + '_' + method_name + ',Step-' + str(method_count_for_file + 1) + '\]"\)', content)

            content = content[:match.end(0)] + '\n\t\tUnityEngine.Debug.Log("[SceneName,Order-1,' + file_directory + ',CS-' + file_name[:-3] + ',METHOD-' + method_name + ',Method-' + str(method_count_for_file + 1) + ',' + 'My_little_notes_here' + ']");\n' + content[match.end(0):]
            with open(file_path, 'w') as file:
                file.write(content)
            print(f"Method {method_name}, File Path: {file_path}")

# 3) Define the third process
def update_method_counts(methods):
    # iterate through the methods and their corresponding files
    for method_name, file_path in methods:
        with open(file_path, 'r') as file:
            content = file.read()
        # initialize the counter
        method_counter = 1
        # search for the Method-1 and increase the counter for each match
        method_count_search = re.search(r'Method-1', content)
        while method_count_search:
            # replace Method-1 with the updated method counter
            content = content[:method_count_search.start(0)] + "Method-" + str(method_counter) + content[method_count_search.end(0):]
            method_counter += 1
            method_count_search = re.search(r'Method-1', content)
        print(f"File '{file_path}' has been updated with new method count.")
        with open(file_path, 'w') as file:
            file.write(content)
    print(f"All files have been updated with new method counts.")






# 4) And lastly a block of code running the previous defined processes
if __name__ == "__main__":
    process_methods(path)
    update_methods(methods)
    update_method_counts(methods)



# SceneName (hardcore)
# Order-1 (hardcore)
# counter no s'actualitza



# AFTER IMPORT (fa un check apareixen logs)


# EXCEPTIONS
# "interface IStateInfo"

# OnAwakes?

# INITIAL RUNTIME EDITOR MODE
# ContinuationQueue.cs                  | "public void Run()" (annoying loop)
# PlayerLoopHelper.cs                   | private static void ForceEditorPlayerLoopUpdate()




# PLAY - INIT00_SCENE
# UIMmoCentralAckLoading.cs             | private void Update()
# DefaultLagCompensationManager.cs      | private void LateUpdate()
# DefaultInterestManager.cs             | private void Update()

# EVERY FRAME
# DevExtUtils.cs                        | private static void InvokeDevExtMethods(
# DevExtUtils.cs                        | private static void InvokeDevExtMethods(
# DevExtUtils.cs > UISelectionEntry.cs  | protected virtual void Update()














